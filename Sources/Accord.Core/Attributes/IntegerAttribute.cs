﻿// Accord Core Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2016
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    ///   Specifies that an argument, in a method or function,
    ///   must be an integer bigger than zero.
    /// </summary>
    /// 
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class PositiveIntegerAttribute : IntegerAttribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="PositiveIntegerAttribute"/> class.
        /// </summary>
        /// 
        public PositiveIntegerAttribute()
            : base(1, int.MaxValue) { }

        /// <summary>
        ///   Initializes a new instance of the <see cref="PositiveIntegerAttribute"/> class.
        /// </summary>
        /// 
        public PositiveIntegerAttribute(int minimum)
            : base(minimum, int.MaxValue) { }
    }

    /// <summary>
    ///   Specifies that an argument, in a method or function,
    ///   must be an integer less than zero.
    /// </summary>
    /// 
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class NegativeIntegerAttribute : IntegerAttribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="NegativeIntegerAttribute"/> class.
        /// </summary>
        /// 
        public NegativeIntegerAttribute()
            : base(int.MinValue, -1) { }

        /// <summary>
        ///   Initializes a new instance of the <see cref="NegativeIntegerAttribute"/> class.
        /// </summary>
        /// 
        public NegativeIntegerAttribute(int maximum)
            : base(int.MinValue, maximum) { }
    }

    /// <summary>
    ///   Specifies that an argument, in a method or function,
    ///   must be an integer smaller than or equal to zero.
    /// </summary>
    /// 
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class NonpositiveIntegerAttribute : IntegerAttribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="NonpositiveIntegerAttribute"/> class.
        /// </summary>
        /// 
        public NonpositiveIntegerAttribute()
            : base(int.MinValue, 0) { }
    }

    /// <summary>
    ///   Specifies that an argument, in a method or function,
    ///   must be an integer bigger than or equal to zero.
    /// </summary>
    /// 
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class NonnegativeIntegerAttribute : IntegerAttribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="NonnegativeIntegerAttribute"/> class.
        /// </summary>
        /// 
        public NonnegativeIntegerAttribute()
            : base(0, int.MaxValue) { }
    }

    /// <summary>
    ///   Specifies that an argument, in a method or function,
    ///   must be an integer.
    /// </summary>
    /// 
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class IntegerAttribute : RangeAttribute
    {
        /// <summary>
        ///   Initializes a new instance of the <see cref="IntegerAttribute"/> class.
        /// </summary>
        /// 
        public IntegerAttribute()
            : base(int.MinValue, int.MaxValue) { }

        /// <summary>
        ///   Initializes a new instance of the <see cref="IntegerAttribute"/> class.
        /// </summary>
        /// 
        public IntegerAttribute(int minimum, int maximum)
            : base(minimum, maximum) { }

        /// <summary>
        ///   Gets the minimum allowed field value.
        /// </summary>
        /// 
        public new int Minimum { get { return (int)base.Minimum; } }

        /// <summary>
        ///   Gets the maximum allowed field value.
        /// </summary>
        /// 
        public new int Maximum { get { return (int)base.Maximum; } }
    }
}
