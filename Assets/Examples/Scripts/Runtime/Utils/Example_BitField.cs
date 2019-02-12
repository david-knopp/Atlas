namespace Atlas.Examples
{
    public sealed class Example_BitField
    {
        public enum Flags
        {
            A = 1 << 1, // 0001
            B = 1 << 2, // 0010
            C = 1 << 3, // 0100
        }

        public static void Example()
        {
            // create a bit field with the 'A' and 'C' flags set (0101)
            Flags field = Flags.A | Flags.C;

            // checks if the 'A' bit is enabled
            if ( BitField.IsFlagSet( field, Flags.A ) )
            {
                // clears only the bit representing 'C'
                BitField.ClearFlag( field, Flags.C );
            }
        }
    }
}