﻿/*
 | Version 10.1.84
 | Copyright 2013 Esri
 |
 | Licensed under the Apache License, Version 2.0 (the "License");
 | you may not use this file except in compliance with the License.
 | You may obtain a copy of the License at
 |
 |    http://www.apache.org/licenses/LICENSE-2.0
 |
 | Unless required by applicable law or agreed to in writing, software
 | distributed under the License is distributed on an "AS IS" BASIS,
 | WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 | See the License for the specific language governing permissions and
 | limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Collections;
using ESRI.ArcLogistics.DomainObjects;
using ESRI.ArcLogistics.Data;
using ESRI.ArcLogistics.App.Pages;

namespace ESRI.ArcLogistics.App.Controls
{
    internal class ComboBoxWithNullRow : ComboBoxBasedEditor
    {
        static ComboBoxWithNullRow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ComboBoxWithNullRow), new FrameworkPropertyMetadata(typeof(ComboBoxWithNullRow)));
        }

        #region Protected Override Methods

        /// <summary>
        /// Overrided method insert null item to the top of items list
        /// </summary>
        protected override void _InsertNullItem()
        {
            string nullItem = string.Empty;

            if (AvailableCollection.Count == 0 || (AvailableCollection[0] != null && AvailableCollection[0] != nullItem))
                AvailableCollection.Insert(0, nullItem);
        }

        #endregion
    }
}