﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToPowerDensity
{
    public static class NumberToPowerDensityExtensions
    {
        #region DecawattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DecawattsPerCubicMeter(this int value) => PowerDensity.FromDecawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? DecawattsPerCubicMeter(this int? value) => PowerDensity.FromDecawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DecawattsPerCubicMeter(this long value) => PowerDensity.FromDecawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? DecawattsPerCubicMeter(this long? value) => PowerDensity.FromDecawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DecawattsPerCubicMeter(this double value) => PowerDensity.FromDecawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? DecawattsPerCubicMeter(this double? value) => PowerDensity.FromDecawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DecawattsPerCubicMeter(this float value) => PowerDensity.FromDecawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? DecawattsPerCubicMeter(this float? value) => PowerDensity.FromDecawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DecawattsPerCubicMeter(this decimal value) => PowerDensity.FromDecawattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromDecawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? DecawattsPerCubicMeter(this decimal? value) => PowerDensity.FromDecawattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DeciwattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DeciwattsPerCubicMeter(this int value) => PowerDensity.FromDeciwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? DeciwattsPerCubicMeter(this int? value) => PowerDensity.FromDeciwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DeciwattsPerCubicMeter(this long value) => PowerDensity.FromDeciwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? DeciwattsPerCubicMeter(this long? value) => PowerDensity.FromDeciwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DeciwattsPerCubicMeter(this double value) => PowerDensity.FromDeciwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? DeciwattsPerCubicMeter(this double? value) => PowerDensity.FromDeciwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DeciwattsPerCubicMeter(this float value) => PowerDensity.FromDeciwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? DeciwattsPerCubicMeter(this float? value) => PowerDensity.FromDeciwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity DeciwattsPerCubicMeter(this decimal value) => PowerDensity.FromDeciwattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromDeciwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? DeciwattsPerCubicMeter(this decimal? value) => PowerDensity.FromDeciwattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GigawattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity GigawattsPerCubicMeter(this int value) => PowerDensity.FromGigawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? GigawattsPerCubicMeter(this int? value) => PowerDensity.FromGigawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity GigawattsPerCubicMeter(this long value) => PowerDensity.FromGigawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? GigawattsPerCubicMeter(this long? value) => PowerDensity.FromGigawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity GigawattsPerCubicMeter(this double value) => PowerDensity.FromGigawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? GigawattsPerCubicMeter(this double? value) => PowerDensity.FromGigawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity GigawattsPerCubicMeter(this float value) => PowerDensity.FromGigawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? GigawattsPerCubicMeter(this float? value) => PowerDensity.FromGigawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity GigawattsPerCubicMeter(this decimal value) => PowerDensity.FromGigawattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromGigawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? GigawattsPerCubicMeter(this decimal? value) => PowerDensity.FromGigawattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilowattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity KilowattsPerCubicMeter(this int value) => PowerDensity.FromKilowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? KilowattsPerCubicMeter(this int? value) => PowerDensity.FromKilowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity KilowattsPerCubicMeter(this long value) => PowerDensity.FromKilowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? KilowattsPerCubicMeter(this long? value) => PowerDensity.FromKilowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity KilowattsPerCubicMeter(this double value) => PowerDensity.FromKilowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? KilowattsPerCubicMeter(this double? value) => PowerDensity.FromKilowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity KilowattsPerCubicMeter(this float value) => PowerDensity.FromKilowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? KilowattsPerCubicMeter(this float? value) => PowerDensity.FromKilowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity KilowattsPerCubicMeter(this decimal value) => PowerDensity.FromKilowattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromKilowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? KilowattsPerCubicMeter(this decimal? value) => PowerDensity.FromKilowattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegawattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MegawattsPerCubicMeter(this int value) => PowerDensity.FromMegawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MegawattsPerCubicMeter(this int? value) => PowerDensity.FromMegawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MegawattsPerCubicMeter(this long value) => PowerDensity.FromMegawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MegawattsPerCubicMeter(this long? value) => PowerDensity.FromMegawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MegawattsPerCubicMeter(this double value) => PowerDensity.FromMegawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MegawattsPerCubicMeter(this double? value) => PowerDensity.FromMegawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MegawattsPerCubicMeter(this float value) => PowerDensity.FromMegawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MegawattsPerCubicMeter(this float? value) => PowerDensity.FromMegawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MegawattsPerCubicMeter(this decimal value) => PowerDensity.FromMegawattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMegawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MegawattsPerCubicMeter(this decimal? value) => PowerDensity.FromMegawattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrowattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MicrowattsPerCubicMeter(this int value) => PowerDensity.FromMicrowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MicrowattsPerCubicMeter(this int? value) => PowerDensity.FromMicrowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MicrowattsPerCubicMeter(this long value) => PowerDensity.FromMicrowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MicrowattsPerCubicMeter(this long? value) => PowerDensity.FromMicrowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MicrowattsPerCubicMeter(this double value) => PowerDensity.FromMicrowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MicrowattsPerCubicMeter(this double? value) => PowerDensity.FromMicrowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MicrowattsPerCubicMeter(this float value) => PowerDensity.FromMicrowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MicrowattsPerCubicMeter(this float? value) => PowerDensity.FromMicrowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MicrowattsPerCubicMeter(this decimal value) => PowerDensity.FromMicrowattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMicrowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MicrowattsPerCubicMeter(this decimal? value) => PowerDensity.FromMicrowattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilliwattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MilliwattsPerCubicMeter(this int value) => PowerDensity.FromMilliwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MilliwattsPerCubicMeter(this int? value) => PowerDensity.FromMilliwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MilliwattsPerCubicMeter(this long value) => PowerDensity.FromMilliwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MilliwattsPerCubicMeter(this long? value) => PowerDensity.FromMilliwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MilliwattsPerCubicMeter(this double value) => PowerDensity.FromMilliwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MilliwattsPerCubicMeter(this double? value) => PowerDensity.FromMilliwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MilliwattsPerCubicMeter(this float value) => PowerDensity.FromMilliwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MilliwattsPerCubicMeter(this float? value) => PowerDensity.FromMilliwattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity MilliwattsPerCubicMeter(this decimal value) => PowerDensity.FromMilliwattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromMilliwattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? MilliwattsPerCubicMeter(this decimal? value) => PowerDensity.FromMilliwattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanowattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity NanowattsPerCubicMeter(this int value) => PowerDensity.FromNanowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? NanowattsPerCubicMeter(this int? value) => PowerDensity.FromNanowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity NanowattsPerCubicMeter(this long value) => PowerDensity.FromNanowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? NanowattsPerCubicMeter(this long? value) => PowerDensity.FromNanowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity NanowattsPerCubicMeter(this double value) => PowerDensity.FromNanowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? NanowattsPerCubicMeter(this double? value) => PowerDensity.FromNanowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity NanowattsPerCubicMeter(this float value) => PowerDensity.FromNanowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? NanowattsPerCubicMeter(this float? value) => PowerDensity.FromNanowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity NanowattsPerCubicMeter(this decimal value) => PowerDensity.FromNanowattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromNanowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? NanowattsPerCubicMeter(this decimal? value) => PowerDensity.FromNanowattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PicowattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity PicowattsPerCubicMeter(this int value) => PowerDensity.FromPicowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? PicowattsPerCubicMeter(this int? value) => PowerDensity.FromPicowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity PicowattsPerCubicMeter(this long value) => PowerDensity.FromPicowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? PicowattsPerCubicMeter(this long? value) => PowerDensity.FromPicowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity PicowattsPerCubicMeter(this double value) => PowerDensity.FromPicowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? PicowattsPerCubicMeter(this double? value) => PowerDensity.FromPicowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity PicowattsPerCubicMeter(this float value) => PowerDensity.FromPicowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? PicowattsPerCubicMeter(this float? value) => PowerDensity.FromPicowattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity PicowattsPerCubicMeter(this decimal value) => PowerDensity.FromPicowattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromPicowattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? PicowattsPerCubicMeter(this decimal? value) => PowerDensity.FromPicowattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TerawattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity TerawattsPerCubicMeter(this int value) => PowerDensity.FromTerawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? TerawattsPerCubicMeter(this int? value) => PowerDensity.FromTerawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity TerawattsPerCubicMeter(this long value) => PowerDensity.FromTerawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? TerawattsPerCubicMeter(this long? value) => PowerDensity.FromTerawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity TerawattsPerCubicMeter(this double value) => PowerDensity.FromTerawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? TerawattsPerCubicMeter(this double? value) => PowerDensity.FromTerawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity TerawattsPerCubicMeter(this float value) => PowerDensity.FromTerawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? TerawattsPerCubicMeter(this float? value) => PowerDensity.FromTerawattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity TerawattsPerCubicMeter(this decimal value) => PowerDensity.FromTerawattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromTerawattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? TerawattsPerCubicMeter(this decimal? value) => PowerDensity.FromTerawattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region WattPerCubicMeter

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity WattsPerCubicMeter(this int value) => PowerDensity.FromWattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? WattsPerCubicMeter(this int? value) => PowerDensity.FromWattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity WattsPerCubicMeter(this long value) => PowerDensity.FromWattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? WattsPerCubicMeter(this long? value) => PowerDensity.FromWattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity WattsPerCubicMeter(this double value) => PowerDensity.FromWattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? WattsPerCubicMeter(this double? value) => PowerDensity.FromWattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity WattsPerCubicMeter(this float value) => PowerDensity.FromWattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? WattsPerCubicMeter(this float? value) => PowerDensity.FromWattsPerCubicMeter(value);

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity WattsPerCubicMeter(this decimal value) => PowerDensity.FromWattsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerDensity.FromWattsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static PowerDensity? WattsPerCubicMeter(this decimal? value) => PowerDensity.FromWattsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
