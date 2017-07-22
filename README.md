# stakx.WIC

A COM interop library for .NET that makes Windows Imaging Component (WIC) available to managed code.

[![NuGet](https://img.shields.io/nuget/v/stakx.WIC.svg?style=flat-square)](https://www.nuget.org/packages/stakx.WIC/)

## What is the Windows Imaging Component (WIC)?

> _"The Windows Imaging Component (WIC) is a Component Object Model based imaging codec framework
> introduced in Windows Vista (…) for working with and processing digital images and image metadata."_
> &mdash; from the [Wikipedia article](wikipedia)

 [wikipedia]: https://en.wikipedia.org/wiki/Windows_Imaging_Component

Windows Imaging Component allows you to accomplish tasks such as:

 * decoding and encoding bitmap images or single bitmap image frames in various formats (GIF, ICO, JPEG, PNG, TIFF, and more)
 * reading and writing image metadata
 * converting bitmaps to different pixel formats (bit depth, channels)
 * transforming bitmaps (clip, flip horizontally or vertically, rotate by 90° angles, scale)

## Why would you want to use stakx.WIC?

I originally started this project because I needed a library to do some fairly simple image processing…
inside an ASP.NET web application. And it is this last bit that introduces a few problems.
The .NET Framework does not come with any image processing functionality that is officially supported in server-side code:

 1. There is the `System.Drawing` namespace.
    The facilities in this namespace are based on the GDI+ API. It is officially unsupported in server-side code.
    (Although it usually works just fine, if you know how to avoid memory leaks and work around performance issues;
     regarding this topic, I'd recommend Nathanael Jones' article ["20 Image Resizing Pitfalls"][20-pitfalls].)
    
 2. There is the `System.Windows.Media.Imaging` namespace.
    This one belongs to the Windows Presentation Foundation (WPF) UI framework and contains thin wrappers around the WIC.
    Being part of a UI framework, it is also not an ideal candidate for server-side scenarios.
    (But like GDI+, it often works just fine.)

The nice thing about the WIC is that it is officially supported on Windows servers!
So if you can find a way to use it directly, then you're all good.
And this is exactly what this project offers: a set of type definitions so that you can use the WIC from .NET.

 [20-pitfalls]: http://www.nathanaeljones.com/blog/2009/20-image-resizing-pitfalls

## How do you get started?

 1. Familiarize yourself with the WIC, if you don't know it yet.
    See e.g. the [Windows Imaging Component documentation on MSDN][msdn].

 2. Add the [NuGet package `stakx.WIC`][nuget-package] to your project.
    Alternatively, you can compile this project yourself (you will need Visual Studio 2017 for this), and then
    add a reference to the built `stakx.WIC.dll` assembly to your project.

 3. In your code, start by instantiating a `WICImagingFactory` object.
    Most other WIC components can be created directly or indirectly through this factory object.
    
 [msdn]: https://msdn.microsoft.com/en-us/library/windows/desktop/ee719902.aspx
 [nuget-package]: https://www.nuget.org/packages/stakx.WIC/

## Is there any example code?

This project page does currently not provide any samples to show how exactly one would get stuff done using the WIC API.
Until I find the time to write some sample code in the future, please refer to the the WIC samples on [MSDN].
I have strived to keep the COM interop types in this project as close as possible to the original COM type definitions.
This should make it fairly easy for you to draw the connection between what you read on MSDN, and this .NET library.
