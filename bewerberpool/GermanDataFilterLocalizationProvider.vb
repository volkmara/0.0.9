Imports Telerik.WinControls.UI

Public Class GermanDataFilterLocalizationProvider
    Inherits Telerik.WinControls.UI.DataFilterLocalizationProvider
    Public Overrides Function GetLocalizedString(id As String) As String
        Select Case id
            Case DataFilterStringId.LogicalOperatorAnd
                Return "Alle"
            Case DataFilterStringId.LogicalOperatorOr
                Return "Irgendeine"
            Case DataFilterStringId.LogicalOperatorDescription
                Return " der folgenden Bedingungen ist wahr"
            Case DataFilterStringId.FieldNullText
                Return "Feld auswählen"
            Case DataFilterStringId.ValueNullText
                Return "Einen Wert eintragen"
            Case DataFilterStringId.AddNewButtonText
                Return "Hinzufügen"
            Case DataFilterStringId.AddNewButtonExpression
                Return "Ausdruck"
            Case DataFilterStringId.AddNewButtonGroup
                Return "Gruppe"
            Case DataFilterStringId.DialogTitle
                Return "Datenfilter"
            Case DataFilterStringId.DialogOKButton
                Return "OK"
            Case DataFilterStringId.DialogCancelButton
                Return "Abbrechen"
            Case DataFilterStringId.DialogApplyButton
                Return "Anwenden"
            Case DataFilterStringId.ErrorAddNodeDialogTitle
                Return "Datenfilter Fehler"
            Case DataFilterStringId.ErrorAddNodeDialogText
                Return "Cannot add entries to the control - missing property descriptors. " & vbLf & "DataSource is not set and/or DataFilterDescriptorItems are not added to the Descriptors collection of the control."
            Case DataFilterStringId.FilterFunctionBetween
                Return "Zwischen"
            Case DataFilterStringId.FilterFunctionContains
                Return "Enthält"
            Case DataFilterStringId.FilterFunctionDoesNotContain
                Return "Enthält nicht"
            Case DataFilterStringId.FilterFunctionEndsWith
                Return "Endet mit"
            Case DataFilterStringId.FilterFunctionEqualTo
                Return "Gleich"
            Case DataFilterStringId.FilterFunctionGreaterThan
                Return "Größer als"
            Case DataFilterStringId.FilterFunctionGreaterThanOrEqualTo
                Return "Größer oder gleich als"
            Case DataFilterStringId.FilterFunctionIsEmpty
                Return "Ist leer"
            Case DataFilterStringId.FilterFunctionIsNull
                Return "Ist Null"
            Case DataFilterStringId.FilterFunctionLessThan
                Return "Kleiner als"
            Case DataFilterStringId.FilterFunctionLessThanOrEqualTo
                Return "Kleiner oder gleich"
            Case DataFilterStringId.FilterFunctionNoFilter
                Return "Kein Filter"
            Case DataFilterStringId.FilterFunctionNotBetween
                Return "Nicht zwischen"
            Case DataFilterStringId.FilterFunctionNotEqualTo
                Return "Nicht gleich mit"
            Case DataFilterStringId.FilterFunctionNotIsEmpty
                Return "Ist nicht leer"
            Case DataFilterStringId.FilterFunctionNotIsNull
                Return "Ist nicht Null"
            Case DataFilterStringId.FilterFunctionStartsWith
                Return "Beginnt mit"
            Case DataFilterStringId.FilterFunctionCustom
                Return "Eigener Filter"
        End Select
        Return MyBase.GetLocalizedString(id)
    End Function
End Class
