﻿using System.Collections.Generic;

namespace RulesChain.Contracts
{
    /// <summary>
    /// The context used to share data between rules
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRuleContext<T>
    {
        /// <summary>
        /// Gets a key/value collection that can be used to share data between rules.
        /// </summary>
        IDictionary<string, object> Properties { get; }

        /// <summary>
        /// The specific context of a rule chain
        /// </summary>
        T Context { get; }
    }
}