﻿using System.Collections.Generic;
using Jotunn.Managers;

namespace Jotunn.Configs
{
    /// <summary>
    ///     Configuration class for adding custom key hints.
    /// </summary>
    public class KeyHintConfig
    {
        /// <summary>
        ///     Item for which the KeyHint should be displayed when equipped.<br />
        ///     Must be the name of the prefab as registered in the <see cref="ItemManager"/>.
        /// </summary>
        public string Item { get; set; } = string.Empty;

        /// <summary>
        ///     If not null or empty the KeyHint will also be bound to a specific 
        ///     <see cref="global::Piece"/> which must be selected for building.
        /// </summary>
        public string Piece { get; set; } = string.Empty;

        /// <summary>
        ///     Array of <see cref="ButtonConfig"/>s used for this key hint.
        /// </summary>
        public ButtonConfig[] ButtonConfigs { get; set; } = new ButtonConfig[0];

        /// <inheritdoc/>
        public override string ToString()
        {
            string ret = Item;
            if (!string.IsNullOrEmpty(Piece))
            {
                ret = $"{ret}:{Piece}";
            }
            return ret;
        }
    }
}
