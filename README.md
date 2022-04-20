[![release](https://github.com/wojciechswietek/PerDiemCalculator/actions/workflows/release.yml/badge.svg)](https://github.com/wojciechswietek/PerDiemCalculator/actions/workflows/release.yml)

# Per Diem Calculator

Windows Forms C#/.NET application to calculate total allowance to receive for international business trips.


## Getting started

A quick introduction of the minimal setup you need to get the calculator up &
running.

For stable release:
```shell
1. Download latest.zip from https://github.com/wojciechswietek/PerDiemCalculator/releases
2. Open PerDiemUI.exe
```

For latest release:
```shell
1. Go to https://github.com/wojciechswietek/PerDiemCalculator/actions
2. Open latest succesful build.
3. Download release.zip artifact.
4. Open PerDiemUI.exe
5. Optional: remove all files but: PerDiemUI.exe, PerDiemUI.dll.config and countries.csv.
```


### Initial Configuration

Using current exchange rate:
```shell
1. Go to https://free.currencyconverterapi.com/free-api-key & get your api key
2. Open PerDiemUI.dll.config and replace YOUR_API_KEY with your key.
3. In PerDiemUI app mark "current" checkbox to receive currency exchange ratio.
```

Using calculator in your counry:
```shell
1. Open PerDiemUI.dll.config and replace currency value to your domestic currency.
3. Modify countries.csv to set rates used in your country.
```

## Features

This project makes it easy to:
* Calculate your total allowance for international business trips.
* Get current exchange ratio from web.
* Get total allowance in your domestic currency.
* Calculate amount to receive/return at the end of your trip base on advance payment received.

## Contributing

If you have any ideas, just add a new issue and tell me what you think.

If you'd like to contribute, please fork the repository and make changes as
you'd like. Pull requests are warmly welcome.

## Licensing

This project is licensed under GNU General Public License v3.0.
