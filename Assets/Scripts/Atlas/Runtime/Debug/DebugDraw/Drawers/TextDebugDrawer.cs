using System;
using System.Collections.Generic;
using UnityEngine;

namespace Atlas
{
    // Inspired by LotteMakesStuff's segment font: https://gist.github.com/LotteMakesStuff/ceb66cb29cb7d3c07da1207ab5d12045
    // and https://www.keshikan.net/img/dseg_sample.png
    public sealed class TextDebugDrawer : IDebugDrawer
    {
        public TextDebugDrawer( Vector3 position, string text, Color color, float fontSize )
        {
            m_position = position;
            Color = color;
            m_fontSize = fontSize;

            m_textLines = text.Split( s_newlineCharacters, StringSplitOptions.RemoveEmptyEntries );
        }

        public bool IsFinished
        {
            get
            {
                return true;
            }
        }

        public Color Color
        {
            get;
            set;
        }

        public void Draw()
        {
            Vector3 position = m_position;

            foreach ( var text in m_textLines )
            {
                foreach ( char character in text )
                {
                    DrawCharacter( char.ToLower( character ), position );
                    position.x += ( c_fontWidthPct * m_fontSize + c_characterSpacingPct * m_fontSize );
                }

                // add newline
                position.x = m_position.x;
                position.y -= ( c_fontHeightPct * m_fontSize + c_characterSpacingPct * m_fontSize );
            }
        }

        private struct Segment
        {
            public Segment( int pointA, int pointB )
            {
                m_startOffset = pointA;
                m_endOffset = pointB;
            }

            public int m_startOffset;
            public int m_endOffset;
        }

        [Flags]
        private enum Location : short
        {
            // horizontal
            H_Top = 1 << 0,
            H_Bottom = 1 << 1,
            H_MidLeft = 1 << 2,
            H_MidRight = 1 << 3,

            // vertical
            V_TopLeft = 1 << 4,
            V_TopMid = 1 << 5,
            V_TopRight = 1 << 6,

            V_BottomLeft = 1 << 7,
            V_BottomMid = 1 << 8,
            V_BottomRight = 1 << 9,

            // diagonal
            D_TopLeft = 1 << 10,
            D_TopRight = 1 << 11,
            D_BottomLeft = 1 << 12,
            D_BottomRight = 1 << 13
        }

        private static readonly Vector3[] s_offsets;
        private static readonly Segment[] s_segments;
        private static readonly Dictionary<char, Location> s_charSegments;
        private static readonly char[] s_newlineCharacters = new char[] { '\n', '\r' };

        private const int c_numSegments = 14;
        private const float c_fontWidthPct = 0.6f;
        private const float c_fontHeightPct = 1f;
        private const float c_characterSpacingPct = 0.1f;
        private const Location c_invalidCharSegments = Location.H_MidLeft | Location.H_MidRight |
                                                       Location.D_TopLeft | Location.D_TopRight | Location.D_BottomLeft | Location.D_BottomRight;

        private string[] m_textLines;
        private float m_fontSize;
        private Vector3 m_position;

        static TextDebugDrawer()
        {
            //   0_1_2
            //   |\|/|
            //  3——4——5       
            //   |/|\|
            //   6‾7‾8
            s_offsets = new Vector3[]
            {
                new Vector3( c_fontWidthPct * -0.5f, c_fontHeightPct * 0.5f ),    new Vector3( 0f, c_fontHeightPct * 0.5f ), new Vector3( c_fontWidthPct * 0.5f, c_fontHeightPct * 0.5f ),
                new Vector3( c_fontWidthPct * -0.5f, 0f ),                        new Vector3( 0f, 0f ),                     new Vector3( c_fontWidthPct * 0.5f, 0f ),
                new Vector3( c_fontWidthPct * -0.5f, c_fontHeightPct * -0.5f ),   new Vector3( 0f, c_fontHeightPct * -0.5f ), new Vector3( c_fontWidthPct * 0.5f, c_fontHeightPct * -0.5f )
            };

            s_segments = new Segment[]
            {
                new Segment( 0, 2 ), // Horizontal_Top
                new Segment( 6, 8 ), // Horizontal_Bottom
                new Segment( 3, 4 ), // Horizontal_MidLeft
                new Segment( 4, 5 ), // Horizontal_MidRight

                new Segment( 0, 3 ), // Vertical_TopLeft
                new Segment( 1, 4 ), // Vertical_TopMid
                new Segment( 2, 5 ), // Vertical_TopRight
                
                new Segment( 3, 6 ), // Vertical_BottomLeft
                new Segment( 4, 7 ), // Vertical_BottomMid
                new Segment( 5, 8 ), // Vertical_BottomRight

                new Segment( 0, 4 ), // Diagonal_TopLeft
                new Segment( 2, 4 ), // Diagonal_TopRight
                new Segment( 4, 6 ), // Diagonal_BottomLeft
                new Segment( 4, 8 ), // Diagonal_BottomRight        
            };

            s_charSegments = new Dictionary<char, Location>();

            // symbols
            s_charSegments.Add( ' ', 0 );
            s_charSegments.Add( '-', Location.H_MidLeft | Location.H_MidRight );
            s_charSegments.Add( '+', Location.H_MidLeft | Location.H_MidRight | Location.V_TopMid | Location.V_BottomMid );
            s_charSegments.Add( ',', Location.D_BottomLeft );
            s_charSegments.Add( '.', Location.V_BottomMid );
            s_charSegments.Add( '=', Location.H_Bottom | Location.H_MidLeft | Location.H_MidRight );
            s_charSegments.Add( '/', Location.D_BottomLeft | Location.D_TopRight );
            s_charSegments.Add( '\\', Location.D_TopLeft | Location.D_BottomRight );
            s_charSegments.Add( '<', Location.D_TopRight | Location.D_BottomRight );
            s_charSegments.Add( '>', Location.D_TopLeft | Location.D_BottomLeft );
            s_charSegments.Add( '\'', Location.V_TopMid );
            s_charSegments.Add( '`', Location.D_TopLeft );
            s_charSegments.Add( '?', Location.H_Top | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_TopRight | Location.V_BottomMid );
            s_charSegments.Add( '$', Location.H_Top | Location.H_Bottom | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_BottomRight | Location.V_TopMid | Location.V_BottomMid );


            // english alphabet
            s_charSegments.Add( 'a', Location.H_Top | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_TopRight | Location.V_BottomLeft | Location.V_BottomRight );
            s_charSegments.Add( 'b', Location.H_Top | Location.H_MidRight | Location.H_Bottom |
                                     Location.V_TopMid | Location.V_TopRight | Location.V_BottomMid | Location.V_BottomRight );
            s_charSegments.Add( 'c', Location.H_Top | Location.H_Bottom | Location.V_TopLeft | Location.V_BottomLeft );
            s_charSegments.Add( 'd', Location.H_Top | Location.H_Bottom |
                                     Location.V_TopRight | Location.V_BottomRight | Location.V_TopMid | Location.V_BottomMid );
            s_charSegments.Add( 'e', Location.H_Top | Location.H_Bottom | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_BottomLeft );
            s_charSegments.Add( 'f', Location.H_Top | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_BottomLeft );
            s_charSegments.Add( 'g', Location.H_Top | Location.H_Bottom | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_BottomLeft | Location.V_BottomRight );
            s_charSegments.Add( 'h', Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_BottomLeft | Location.V_TopRight | Location.V_BottomRight );
            s_charSegments.Add( 'i', Location.H_Top | Location.H_Bottom | Location.V_TopMid | Location.V_BottomMid );
            s_charSegments.Add( 'j', Location.H_Bottom | Location.V_TopRight | Location.V_BottomRight | Location.V_BottomLeft );
            s_charSegments.Add( 'k', Location.H_MidLeft | Location.V_TopLeft | Location.V_BottomLeft | Location.D_TopRight | Location.D_BottomRight );
            s_charSegments.Add( 'l', Location.H_Bottom | Location.V_TopLeft | Location.V_BottomLeft );
            s_charSegments.Add( 'm', Location.V_TopLeft | Location.V_BottomLeft | Location.V_BottomMid | Location.V_TopRight | Location.V_BottomRight |
                                     Location.D_TopLeft | Location.D_TopRight );
            s_charSegments.Add( 'n', Location.V_TopLeft | Location.V_BottomLeft | Location.V_TopRight | Location.V_BottomRight |
                                     Location.D_TopLeft | Location.D_BottomRight );
            s_charSegments.Add( 'o', Location.H_Top | Location.H_Bottom |
                                     Location.V_TopLeft | Location.V_BottomLeft | Location.V_TopRight | Location.V_BottomRight );
            s_charSegments.Add( 'p', Location.H_Top | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_BottomLeft | Location.V_TopRight );
            s_charSegments.Add( 'q', Location.H_Top | Location.H_Bottom |
                                     Location.V_TopLeft | Location.V_BottomLeft | Location.V_TopRight | Location.V_BottomRight |
                                     Location.D_BottomRight );
            s_charSegments.Add( 'r', Location.H_Top | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_BottomLeft | Location.V_TopRight |
                                     Location.D_BottomRight );
            s_charSegments.Add( 's', Location.H_Top | Location.H_Bottom | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_BottomRight |
                                     Location.D_TopLeft | Location.D_BottomRight );
            s_charSegments.Add( 't', Location.H_Top | Location.V_TopMid | Location.V_BottomMid );
            s_charSegments.Add( 'u', Location.H_Bottom |
                                     Location.V_TopLeft | Location.V_BottomLeft | Location.V_TopRight | Location.V_BottomRight );
            s_charSegments.Add( 'v', Location.V_TopLeft | Location.V_BottomLeft | Location.D_TopRight | Location.D_BottomLeft );
            s_charSegments.Add( 'w', Location.V_TopLeft | Location.V_BottomLeft | Location.V_TopMid | Location.V_TopRight | Location.V_BottomRight |
                                     Location.D_BottomLeft | Location.D_BottomRight );
            s_charSegments.Add( 'x', Location.D_TopLeft | Location.D_TopRight | Location.D_BottomLeft | Location.D_BottomRight );
            s_charSegments.Add( 'y', Location.V_BottomMid | Location.D_TopLeft | Location.D_TopRight );
            s_charSegments.Add( 'z', Location.H_Top | Location.H_Bottom | Location.D_TopRight | Location.D_BottomLeft );

            // numbers
            s_charSegments.Add( '0', Location.H_Top | Location.H_Bottom |
                                     Location.V_TopLeft | Location.V_BottomLeft | Location.V_TopRight | Location.V_BottomRight |
                                     Location.D_BottomLeft | Location.D_TopRight );
            s_charSegments.Add( '1', Location.V_TopRight | Location.V_BottomRight );
            s_charSegments.Add( '2', Location.H_Top | Location.H_Bottom | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopRight | Location.V_BottomLeft );
            s_charSegments.Add( '3', Location.H_Top | Location.H_Bottom | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopRight | Location.V_BottomRight );
            s_charSegments.Add( '4', Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_TopRight | Location.V_BottomRight );
            s_charSegments.Add( '5', Location.H_Top | Location.H_Bottom | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_BottomRight );
            s_charSegments.Add( '6', Location.H_Top | Location.H_Bottom | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_BottomLeft | Location.V_TopLeft | Location.V_BottomRight );
            s_charSegments.Add( '7', Location.H_Top | Location.V_TopLeft | Location.V_TopRight | Location.V_BottomRight );
            s_charSegments.Add( '8', Location.H_Top | Location.H_Bottom | Location.H_MidLeft | Location.H_MidRight |
                                     Location.V_TopLeft | Location.V_BottomLeft | Location.V_TopRight | Location.V_BottomRight );
            s_charSegments.Add( '9', Location.H_Top | Location.H_MidLeft | Location.H_MidRight | 
                                     Location.V_TopLeft | Location.V_TopRight | Location.V_BottomRight );
        }

        private void DrawCharacter( char character, Vector3 position )
        {
            Location segments;
            if ( s_charSegments.TryGetValue( character, out segments ) == false )
            {
                segments = c_invalidCharSegments;
            }

            for ( int i = 0; i < c_numSegments; i++ )
            {
                if ( BitField.IsFlagSet( segments, ( Location )( 1 << i ) ) )
                {
                    DrawSegment( position, s_segments[i] );
                }
            }
        }

        private void DrawSegment( Vector3 position, Segment segment )
        {
            Vector3 startPos = position + s_offsets[segment.m_startOffset] * m_fontSize;
            Vector3 endPos = position + s_offsets[segment.m_endOffset] * m_fontSize;

            GL.Begin( GL.LINES );
            GL.Color( Color );

            GL.Vertex( startPos );
            GL.Vertex( endPos );

            GL.End();
        }
    }
}