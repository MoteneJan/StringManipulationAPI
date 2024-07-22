# String Manipulation API
![Palindrome](https://github.com/user-attachments/assets/4cf7f2e4-bc9b-4d44-ac6f-870466136865)

## Overview

This API provides functionalities to reverse a string and check if a string is a palindrome.

Prerequisites
.NET 6 SDK - The project requires the .NET 6 SDK or Higher. Ensure it is installed and configured on your machine.

## Setup

## Git clone the repository
git clone https://github.com/MoteneJan/StringManipulationAPI.git
cd StringManipulationAPI

## Endpoints

### GET /api/v1/StringManipulation

**Parameters:**

- `input` (query string parameter): The input string to be processed.
- e.g,. `input` - "racecar"

**Response:**

```json
{
  "ReversedString": "your reversed string",
  "IsPalindrome": true/false
}
