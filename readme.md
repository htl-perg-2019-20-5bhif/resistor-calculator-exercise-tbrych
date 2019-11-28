# Resistor Colors Exercise

## Introduction

Your job is to create a mobile app with which engineers can calculate resistor values from color codes and vice versa. You app only needs to support *4 band resistors*.

![Resistor Color Coding](https://lh3.googleusercontent.com/proxy/3l4gjeoNUKpub3lRbnBCSZAHhe0JqWESjc37D67Ig-lCYicb4WkhbGaWXK8MdbSUPyLK8UfcbPREb2Q30x682D9lr-VE0trGggWrnBHP-igq8gOgDZ221uTjKkCgfv4sE8BW6FMZuN8=s0-d)

(Source: [How To Calculate And Understand Resistor Values](https://learntodiscover-science.blogspot.com/2016/10/how-to-calculate-and-understand.html))

## Requirements

* Build a *Xamarin Forms* mobile app. If this is technically not possible for you, write a *WPF* app (*.NET Core 3*) instead.

* The app must support two modes:
  * Selecting colors and calculating the resistor's value from them.
  * Entering a resistor's value and calculating the colors from it.

### Color to Resistor Value

* The user must be able to select the color for each of the four color bands using a *Picker* (WPF: *Combo Box*). Only valid colors must be available.

* Once the user has selected all colors, the resistor's value must be calculated and displayed.

* **Earn an extra point**: Display a visual representation of the resistor similar to this:

![Resistor](resistor-schematics.svg)

### Resistor Value to Colors

This part of the exercise is optional. **Earn an extra point** if you implement it.

* The user must be able to enter a resistor value.

* If the value is not valid (i.e. cannot be represented with resistor color codes), display an error message.

* If the value is valid, display the color codes.

* **Earn an extra point**: Display a visual representation of the resistor similar to this:

![Resistor](resistor-schematics.svg)
