# RiotSlider
### Implementing a Slider Control as a CustomControl in WPF and OpenSilver

WPF (Windows Presentation Foundation) was the first platform to introduce XAML (eXtensible Application Markup Language). It is recognized as one of the most powerful methods for application development on the Windows operating system to this day and has significantly contributed to the evolution of XAML-based platforms.

WPF provides a rich user interface and advanced graphics capabilities, with XAML enabling an effective separation of user interface and logic. Similarly, the Silverlight platform shares a development approach with WPF, but primarily focuses on web-based applications.

Recently, [OpenSilver](https://opensilver.net/) has evolved to version 2.0, further stabilizing and offering a near-identical implementation to WPF and Silverlight, while enabling website development based on WebAssembly. This opens new possibilities for applying WPF and Silverlight development techniques in web environments.

Cross-platform development tools like Avalonia UI and Uno Platform are also continuously evolving. These platforms enable robust application development across various environments, offering developers a wide range of choices.

All these developments are examples of how XAML-based platforms have evolved and expanded over time, supporting developers in creating effective and efficient applications in diverse environments.

## Introduction
### League of Legends Style Slider: Implemented in WPF and OpenSilver with the Same XAML, Different Approaches

RiotSlider is a slider control inspired by the League of Legends game, adapted for the WPF and OpenSilver environments. This project uses the same XAML in both WPF and OpenSilver while adopting unique implementation methods suitable for each environment. It provides an opportunity to explore and understand the similarities and differences in control implementation techniques across these two technology stacks.

## Features
### Custom Implementation of Slider Inheritance in WPF and OpenSilver

- **Support for WPF and OpenSilver:** Provides the RiotSlider control usable in both WPF and OpenSilver environments.
- **Custom Control Approach:** Extends the basic Slider functionality to implement a user interface and interactions styled after League of Legends.
- **Consistent Experience, Diverse Technologies:** Offers a consistent user experience in both environments while highlighting their technical differences.

## Installation and Usage
### What to Know Before Getting Started

#### Requirements

- **.NET Version:** 
  - WPF version requires .NET 8.0 or higher.
  - [OpenSilver](https://opensilver.net/) version requires .NET 7.0 or higher.
- **Development Environment:** [Visual Studio 2022](https://visualstudio.microsoft.com/)

#### Starting Projects

- Starting project for WPF version: `WpfRiotSlider`
- Starting project for OpenSilver version: `OpenSilverRiotSlider.Browser`

## Project Structure

The repository is organized as follows:

- **WPF (Solution Folder):** The RiotSlider project based on WPF.
- **OpenSilver (Solution Folder):** The RiotSlider project based on OpenSilver.

Each solution folder contains project files and source code suitable for the respective environment.

## Screenshots
### Showcasing the RiotSlider in Action on Each Platform

The images below illustrate the RiotSlider, inherited from the Slider control, as it appears when executed on each respective platform. These visuals demonstrate the implementation and appearance of the RiotSlider in both the WPF and OpenSilver environments, highlighting the successful adaptation of the control across different technologies.

![RiotSlider WPF Version](https://github.com/jamesnet214/riotslider/assets/52397976/6fbd58bc-7f6d-4372-9039-be0312a68103)

![RiotSlider OpenSilver Version](https://github.com/jamesnet214/riotslider/assets/52397976/95fb9707-305a-457c-8d0c-a5034bbda9be)

## License
### Embracing Openness and Collaboration with the MIT License

This project is open-sourced under the MIT License. This means anyone can freely use, copy, modify, merge, publish, distribute, grant sublicenses, and/or sell the software, and it requires that users comply with these terms when receiving the software.

For more details, refer to the [LICENSE file](LICENSE file link).
