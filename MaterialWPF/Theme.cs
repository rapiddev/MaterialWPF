// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace MaterialWPF
{
    /// <summary>
    /// Themes available for the Material WPF library
    /// </summary>
    public enum MaterialTheme
    {
        Unknown,
        Light,
        Dark
    }

    /// <summary>
    /// Get information about the currently set theme and can change it with <see cref="Switch"/>
    /// </summary>
    public class Theme
    {
        private static readonly string _mwpfUri = "pack://application:,,,/MaterialWPF;component/Styles/Theme";

        /// <summary>
        /// Gets the contents of the merged dictionaries in <see cref="Application.Resources"/> and verifies currently set theme.
        /// </summary>
        /// <returns>Currently set <see cref="MaterialTheme"/></returns>
        public static MaterialTheme Current
        {
            get
            {
                MaterialTheme returnTheme;

                Collection<ResourceDictionary> applicationDictionaries = Application.Current.Resources.MergedDictionaries;
                if(applicationDictionaries.Count == 0)
                    return MaterialTheme.Unknown;

                for (int i = 0; i < applicationDictionaries.Count; i++)
                {
                    returnTheme = CheckDicionaryContent(applicationDictionaries[i]);

                    if (returnTheme != MaterialTheme.Unknown)
                        return returnTheme;

                    if (applicationDictionaries[i].MergedDictionaries != null)
                    {
                        for (int j = 0; j < applicationDictionaries[i].MergedDictionaries.Count; j++)
                        {
                            returnTheme = CheckDicionaryContent(applicationDictionaries[i].MergedDictionaries[j]);

                            if (returnTheme != MaterialTheme.Unknown)
                                return returnTheme;
                        }
                    }
                }

                return MaterialTheme.Unknown;
            }
        }

        /// <summary>
        /// Changes the currently set <see cref="MaterialTheme"/>, if one is set.
        /// </summary>
        public static void Switch(MaterialTheme theme)
        {
            Collection<ResourceDictionary> applicationDictionaries = Application.Current.Resources.MergedDictionaries;
            if (applicationDictionaries.Count == 0)
                return;

            string sourceName;

            for (int i = 0; i < applicationDictionaries.Count; i++)
            {
                sourceName = applicationDictionaries[i].Source.ToString().ToLower().Trim();

                if (sourceName.Contains("materialwpf;") && sourceName.Contains("theme"))
                {
                    applicationDictionaries[i] = new ResourceDictionary() { Source = new Uri(_mwpfUri + (theme == MaterialTheme.Light ? "Light" : "Dark") + ".xaml", UriKind.Absolute) };
                    return;
                }

                if (applicationDictionaries[i].MergedDictionaries != null)
                {
                    for (int j = 0; j < applicationDictionaries[i].MergedDictionaries.Count; j++)
                    {
                        sourceName = applicationDictionaries[i].MergedDictionaries[j].Source.ToString().ToLower().Trim();

                        if (sourceName.Contains("materialwpf;") && sourceName.Contains("theme"))
                        {
                            applicationDictionaries[i].MergedDictionaries[j] = new ResourceDictionary() { Source = new Uri(_mwpfUri + (theme == MaterialTheme.Light ? "Light" : "Dark") + ".xaml", UriKind.Absolute) };
                            return;
                        }
                    }
                }
            }
        }

        private static MaterialTheme CheckDicionaryContent(ResourceDictionary dictionary)
        {
            string sourceName = dictionary.Source.ToString().ToLower().Trim();
            
            if(sourceName.Contains("materialwpf;") && sourceName.Contains("theme"))
            {
                if (sourceName.Contains("themelight"))
                    return MaterialTheme.Light;
                else
                    return MaterialTheme.Dark;
            }
            else
            {
                return MaterialTheme.Unknown; ;
            }
        }
    }
}
