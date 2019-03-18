# Atlas 👩‍🚀
[![Latest Github release](https://img.shields.io/github/release/david-knopp/atlas.svg)](https://github.com/david-knopp/Atlas/releases/latest)  [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/david-knopp/Atlas/blob/master/LICENSE) [![Github All Releases](https://img.shields.io/github/downloads/david-knopp/atlas/total.svg)](https://github.com/david-knopp/Atlas/releases/latest)
> A C# utility and helper library for Unity.

---

The user manual is a work in progress, and will be expanded upon soon. For now, make sure to check out the [API reference](https://david-knopp.github.io/Atlas/api/Atlas.html "API reference") for documentation and usage examples.

## Summary
Atlas is a library of reusable classes and tools designed to jump-start your Unity project by providing solutions for common tasks, and extending/augmenting the features of Unity and C#.

## Feature Overview
1. Game view debug drawing
2. Easing
3. Inspector attributes
4. Timers
5. Singletons
6. Signals
7. Effect emitters
8. State machines
9. Editor helpers
10. UI stack

## Installation
#### Import using the Package Manager (Unity 2019.1+) 
Add `"com.davidknopp.atlas": "https://github.com/david-knopp/Atlas.git#ReleasePackage",` under the `"dependencies"` section of your project's manifest.json file, which should be located under the "Packages" folder in your project's root directory. Upon running Unity, Atlas should then be
downloaded automatically.

Note: to use this method, Git must be installed on the user machine and the Git executable path should be listed in the PATH system environment variable as explained [on the Unity forum](https://forum.unity.com/threads/git-support-on-package-manager.573673/ "Package Manager Git support - Unity Forum").

#### Import the Unity Package
Download the latest .unitypackage from the [releases page](https://github.com/david-knopp/Atlas/releases "releases page"). Then, simply drag and drop the [package](https://docs.unity3d.com/Manual/AssetPackages.html "package") into your Unity project.  

In an effort to keep your project tidy, Atlas will place itself in `Assets/ThirdParty/Atlas/`, but can be moved freely afterward, as nothing within the library depends upon this directory.

#### Copy/paste the source folders
Download or clone the latest master branch, then copy the assets contained at `Assets/Scripts/` of the Atlas project into your Unity project.

#### Mix & Match
Many of the files & classes contained within Atlas are modular and can be used on their own without any other dependencies. Therefore, individual files can be taken at will from the repository for use within your Unity projects.

## License
[MIT © David Knopp](https://github.com/david-knopp/Atlas/blob/master/LICENSE "MIT © David Knopp")
