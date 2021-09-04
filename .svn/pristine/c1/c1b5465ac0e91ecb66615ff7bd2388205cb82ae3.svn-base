using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;
using System.Windows.Media;
using System.Diagnostics;
using System.Globalization;

using Gore.UserAccess;
using Gore.Generic;

namespace SleeveSewing
{
    /// <summary>
    /// MultiValueConverter for setting the Visibility state of the File_RebootWindows.
    /// </summary>
    internal class File_RebootWindows_Visibility_MultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            // In Design Mode, always return Visible so we can see the control.
            if(System.ComponentModel.DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                return Visibility.Visible;
            }

            Debug.Assert(values.Length == 2);

            for(int i = 0; i < values.Length; i++)
            {
                if(values[i] == null || values[i] == DependencyProperty.UnsetValue)
                {
                    return Visibility.Collapsed;
                }
            }

            bool KioskMode = System.Convert.ToBoolean(values[0]);
            AccessLevel_Enum AccessLevel = (AccessLevel_Enum)values[1];

            if(KioskMode && AccessLevel >= AccessLevel_Enum.MachineOwner)
            {
                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// MultiValueConverter for setting the Visibility state of the File_Exit.
    /// </summary>
    internal class File_Exit_Visibility_MultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            // In Design Mode, always return Visible so we can see the control.
            if(System.ComponentModel.DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                return Visibility.Visible;
            }

            Debug.Assert(values.Length == 2);

            for(int i = 0; i < values.Length; i++)
            {
                if(values[i] == null || values[i] == DependencyProperty.UnsetValue)
                {
                    return Visibility.Collapsed;
                }
            }

            bool KioskMode = System.Convert.ToBoolean(values[0]);
            AccessLevel_Enum AccessLevel = (AccessLevel_Enum)values[1];

            if(AccessLevel >= AccessLevel_Enum.MachineOwner || !KioskMode)
            {
                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
