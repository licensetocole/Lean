﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

namespace QuantConnect.Securities
{
    /// <summary>
    /// Result type for <see cref="IBuyingPowerModel.GetInitialMarginRequirement"/>
    /// and <see cref="IBuyingPowerModel.GetInitialMarginRequiredForOrder"/>
    /// </summary>
    public class InitialMargin
    {
        /// <summary>
        /// The maintenance margin value in account currency
        /// </summary>
        public decimal Value { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitialMargin"/> class
        /// </summary>
        /// <param name="value">The maintenance margin</param>
        public InitialMargin(decimal value)
        {
            Value = value;
        }

        /// <summary>
        /// Implicit operator from decimal
        /// </summary>
        public static implicit operator InitialMargin(decimal initialMargin)
        {
            return new InitialMargin(initialMargin);
        }

        /// <summary>
        /// Implicit operator to decimal
        /// </summary>
        public static implicit operator decimal(InitialMargin initialMargin)
        {
            return initialMargin.Value;
        }
    }
}
