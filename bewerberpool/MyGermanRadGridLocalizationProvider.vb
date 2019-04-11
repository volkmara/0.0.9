Imports Telerik.WinControls.UI.Localization

Public Class MyGermanRadGridLocalizationProvider
    Inherits RadGridLocalizationProvider

    Public Overrides Function GetLocalizedString(id As String) As String
        Select Case id
            Case RadGridStringId.ConditionalFormattingPleaseSelectValidCellValue
                Return "Bitte wählen Sie einen zulässigen Wert aus"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValue
                Return "Bitte geben Sie einen zulässigen Wert ein"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidCellValues
                Return "Bitte geben Sie zulässige Werte ein"
            Case RadGridStringId.ConditionalFormattingPleaseSetValidExpression
                Return "Bitte geben Sie einen gültigen Ausdruck ein"
            Case RadGridStringId.ConditionalFormattingItem
                Return "Item"

            Case RadGridStringId.ConditionalFormattingInvalidParameters
                Return "Ungültige Parameter"
            Case RadGridStringId.FilterFunctionBetween
                Return "Zwischen"
            Case RadGridStringId.FilterFunctionContains
                Return "Enthält"
            Case RadGridStringId.FilterFunctionDoesNotContain
                Return "Enthält nicht"
            Case RadGridStringId.FilterFunctionEndsWith
                Return "Endet mit"
            Case RadGridStringId.FilterFunctionEqualTo
                Return "Gleich"
            Case RadGridStringId.FilterFunctionGreaterThan
                Return "Größer als"
            Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
                Return "Größer als oder gleich"
            Case RadGridStringId.FilterFunctionIsEmpty
                Return "Ist leer"
            Case RadGridStringId.FilterFunctionIsNull
                Return "Ist Null"
            Case RadGridStringId.FilterFunctionLessThan
                Return "Kleiner als"
            Case RadGridStringId.FilterFunctionLessThanOrEqualTo
                Return "Kleiner als oder gleich"
            Case RadGridStringId.FilterFunctionNoFilter
                Return "Kein Filter"
            Case RadGridStringId.FilterFunctionNotBetween
                Return "Nicht zwischen"
            Case RadGridStringId.FilterFunctionNotEqualTo
                Return "Nicht gleich"
            Case RadGridStringId.FilterFunctionNotIsEmpty
                Return "Ist nicht leer"
            Case RadGridStringId.FilterFunctionNotIsNull
                Return "Ist nicht Null"
            Case RadGridStringId.FilterFunctionStartsWith
                Return "Beginnt mit"
            Case RadGridStringId.FilterFunctionCustom
                Return "Eigener Filter"

            Case RadGridStringId.FilterOperatorBetween
                Return "Zwischen"
            Case RadGridStringId.FilterOperatorContains
                Return "Enthält"
            Case RadGridStringId.FilterOperatorDoesNotContain
                Return "Enthält nicht"
            Case RadGridStringId.FilterOperatorEndsWith
                Return "Endet mit"
            Case RadGridStringId.FilterOperatorEqualTo
                Return "Ist Gleich"
            Case RadGridStringId.FilterOperatorGreaterThan
                Return "Größer als"
            Case RadGridStringId.FilterOperatorGreaterThanOrEqualTo
                Return "Größer oder gleich"
            Case RadGridStringId.FilterOperatorIsEmpty
                Return "Ist leer"
            Case RadGridStringId.FilterOperatorIsNull
                Return "Ist Null"
            Case RadGridStringId.FilterOperatorLessThan
                Return "Weniger als"
            Case RadGridStringId.FilterOperatorLessThanOrEqualTo
                Return "Weniger oder Gleich"
            Case RadGridStringId.FilterOperatorNoFilter
                Return "Kein Filter"
            Case RadGridStringId.FilterOperatorNotBetween
                Return "Nicht zwischen"
            Case RadGridStringId.FilterOperatorNotEqualTo
                Return "Ungleich"
            Case RadGridStringId.FilterOperatorNotIsEmpty
                Return "Nicht leer"
            Case RadGridStringId.FilterOperatorNotIsNull
                Return "Nicht Null"
            Case RadGridStringId.FilterOperatorStartsWith
                Return "Beginnt mit"
            Case RadGridStringId.FilterOperatorIsLike
                Return "Ähnlich"
            Case RadGridStringId.FilterOperatorNotIsLike
                Return "Nicht ähnlich"
            Case RadGridStringId.FilterOperatorIsContainedIn
                Return "Enthalten in"
            Case RadGridStringId.FilterOperatorNotIsContainedIn
                Return "Nicht enthalten in"
            Case RadGridStringId.FilterOperatorCustom
                Return "Eigener Filter"

            Case RadGridStringId.CustomFilterMenuItem
                Return "Eigener Filer"
            Case RadGridStringId.CustomFilterDialogCaption
                Return "RadGridView Filter Dialog [{0}]"
            Case RadGridStringId.CustomFilterDialogLabel
                Return "Zeilen anzeigen:"
            Case RadGridStringId.CustomFilterDialogRbAnd
                Return "Und"
            Case RadGridStringId.CustomFilterDialogRbOr
                Return "Oder"
            Case RadGridStringId.CustomFilterDialogBtnOk
                Return "OK"
            Case RadGridStringId.CustomFilterDialogBtnCancel
                Return "Cancel"
            Case RadGridStringId.CustomFilterDialogCheckBoxNot
                Return "Nicht"
            Case RadGridStringId.CustomFilterDialogTrue
                Return "Wahr"
            Case RadGridStringId.CustomFilterDialogFalse
                Return "Falsch"

            Case RadGridStringId.FilterMenuBlanks
                Return "Leer"
            Case RadGridStringId.FilterMenuAvailableFilters
                Return "Verfügbare Filter"
            Case RadGridStringId.FilterMenuSearchBoxText
                Return "Suchen"
            Case RadGridStringId.FilterMenuClearFilters
                Return "Filter löschen"
            Case RadGridStringId.FilterMenuButtonOK
                Return "OK"
            Case RadGridStringId.FilterMenuButtonCancel
                Return "Cancel"
            Case RadGridStringId.FilterMenuSelectionAll
                Return "Alle"
            Case RadGridStringId.FilterMenuSelectionAllSearched
                Return "Suchergebnisse"
            Case RadGridStringId.FilterMenuSelectionNull
                Return "Null"
            Case RadGridStringId.FilterMenuSelectionNotNull
                Return "Nicht Null"

            Case RadGridStringId.FilterFunctionSelectedDates
                Return "Filter nach Datum:"
            Case RadGridStringId.FilterFunctionToday
                Return "Heute"
            Case RadGridStringId.FilterFunctionYesterday
                Return "Gestern"
            Case RadGridStringId.FilterFunctionDuringLast7days
                Return "Während der letzten 7 Tage"

            Case RadGridStringId.FilterLogicalOperatorAnd
                Return "UND"
            Case RadGridStringId.FilterLogicalOperatorOr
                Return "ODER"
            Case RadGridStringId.FilterCompositeNotOperator
                Return "NICHT"

            Case RadGridStringId.DeleteRowMenuItem
                Return "Zeile löschen"
            Case RadGridStringId.SortAscendingMenuItem
                Return "Aufsteigend Sortieren"
            Case RadGridStringId.SortDescendingMenuItem
                Return "Absteigend Sortieren"
            Case RadGridStringId.ClearSortingMenuItem
                Return "Sortierung aufheben"
            Case RadGridStringId.ConditionalFormattingMenuItem
                Return "Bedingte Formatierung"
            Case RadGridStringId.GroupByThisColumnMenuItem
                Return "Nach dieser Spalte gruppieren"
            Case RadGridStringId.UngroupThisColumn
                Return "Gruppierung aufheben"
            Case RadGridStringId.ColumnChooserMenuItem
                Return "Spaltenauswahl"
            Case RadGridStringId.HideMenuItem
                Return "Spalte ausblenden"
            Case RadGridStringId.HideGroupMenuItem
                Return "Gruppe ausblenden"
            Case RadGridStringId.UnpinMenuItem
                Return "Spalte lösen"
            Case RadGridStringId.UnpinRowMenuItem
                Return "Zeile lösen"
            Case RadGridStringId.PinMenuItem
                Return "Fixierstatus"
            Case RadGridStringId.PinAtLeftMenuItem
                Return "Fixiert links"
            Case RadGridStringId.PinAtRightMenuItem
                Return "Fixiert rechts"
            Case RadGridStringId.PinAtBottomMenuItem
                Return "Fixiert unten"
            Case RadGridStringId.PinAtTopMenuItem
                Return "Fixiert oben"
            Case RadGridStringId.BestFitMenuItem
                Return "Optimale Breite"
            Case RadGridStringId.PasteMenuItem
                Return "Einfügen"
            Case RadGridStringId.EditMenuItem
                Return "Bearbeiten"
            Case RadGridStringId.ClearValueMenuItem
                Return "Wert löschen"
            Case RadGridStringId.CopyMenuItem
                Return "Kopieren"
            Case RadGridStringId.CutMenuItem
                Return "Ausschneiden"
            Case RadGridStringId.AddNewRowString
                Return "Klicken für neue Zeile"
            Case RadGridStringId.SearchRowResultsOfLabel
                Return "von"
            Case RadGridStringId.SearchRowMatchCase
                Return "Groß- und Kleinschreibung"
            Case RadGridStringId.ConditionalFormattingSortAlphabetically
                Return "alphabetisch sortieren"
            Case RadGridStringId.ConditionalFormattingCaption
                Return "Bedingte Formatierungen einstellen"
            Case RadGridStringId.ConditionalFormattingLblColumn
                Return "Nur Zellen mit diesem Wert formatieren"
            Case RadGridStringId.ConditionalFormattingLblName
                Return "Regelname"
            Case RadGridStringId.ConditionalFormattingLblType
                Return "Zellwert"
            Case RadGridStringId.ConditionalFormattingLblValue1
                Return "Wert 1"
            Case RadGridStringId.ConditionalFormattingLblValue2
                Return "Wert 2"
            Case RadGridStringId.ConditionalFormattingGrpConditions
                Return "Regeln"
            Case RadGridStringId.ConditionalFormattingGrpProperties
                Return "Regeleigenschaften"
            Case RadGridStringId.ConditionalFormattingChkApplyToRow
                Return "Ganze Zeile formatieren"
            Case RadGridStringId.ConditionalFormattingChkApplyOnSelectedRows
                Return "Nur ganze ausgewählte Zeile formatieren"
            Case RadGridStringId.ConditionalFormattingBtnAdd
                Return "Neue Regel hinzufügen"
            Case RadGridStringId.ConditionalFormattingBtnRemove
                Return "Entfernen"
            Case RadGridStringId.ConditionalFormattingBtnOK
                Return "OK"
            Case RadGridStringId.ConditionalFormattingBtnCancel
                Return "Cancel"
            Case RadGridStringId.ConditionalFormattingBtnApply
                Return "Anwenden"
            Case RadGridStringId.ConditionalFormattingRuleAppliesOn
                Return "Regel anwenden auf"
            Case RadGridStringId.ConditionalFormattingCondition
                Return "Bedingung"
            Case RadGridStringId.ConditionalFormattingExpression
                Return "Ausdruck"
            Case RadGridStringId.ConditionalFormattingChooseOne
                Return "[Auswählen]"
            Case RadGridStringId.ConditionalFormattingEqualsTo
                Return "gleich mit [Value1]"
            Case RadGridStringId.ConditionalFormattingIsNotEqualTo
                Return "ist nicht gleich mit [Value1]"
            Case RadGridStringId.ConditionalFormattingStartsWith
                Return "beginnt mit [Value1]"
            Case RadGridStringId.ConditionalFormattingEndsWith
                Return "endet mit [Value1]"
            Case RadGridStringId.ConditionalFormattingContains
                Return "enthält [Value1]"
            Case RadGridStringId.ConditionalFormattingDoesNotContain
                Return "enthält nicht [Value1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThan
                Return "ist größer als [Value1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual
                Return "ist größer als oder gleich [Value1]"
            Case RadGridStringId.ConditionalFormattingIsLessThan
                Return "ist kleiner als [Value1]"
            Case RadGridStringId.ConditionalFormattingIsLessThanOrEqual
                Return "ist kleiner als oder gleich to [Value1]"
            Case RadGridStringId.ConditionalFormattingIsBetween
                Return "liegt zwischen [Value1] und [Value2]"
            Case RadGridStringId.ConditionalFormattingIsNotBetween
                Return "liegt nicht zwischen [Value1] und [Value1]"
            Case RadGridStringId.ConditionalFormattingLblFormat
                Return "Format"

            Case RadGridStringId.ConditionalFormattingBtnExpression
                Return "Ausdruckseditor"
            Case RadGridStringId.ConditionalFormattingTextBoxExpression
                Return "Ausdruck"

            Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitive
                Return "Groß- und Kleinschreibung"
            Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColor
                Return "Zellenhintergrundfarbe"
            Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColor
                Return "Zellenvordergrundfarbe"
            Case RadGridStringId.ConditionalFormattingPropertyGridEnabled
                Return "Aktiviert"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColor
                Return "Zeilenhintergrundfarbe"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColor
                Return "Zeilenvordergrundfarbe"
            Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignment
                Return "Zeilenausrichtung"
            Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignment
                Return "Textausrichtung"

            Case RadGridStringId.ConditionalFormattingPropertyGridCaseSensitiveDescription
                Return "Legt fest, ob Groß- und Kleinschreibung beachtet wird."
            Case RadGridStringId.ConditionalFormattingPropertyGridCellBackColorDescription
                Return "Geben Sie die Hintergrundfarbe für diese Zelle ein."
            Case RadGridStringId.ConditionalFormattingPropertyGridCellForeColorDescription
                Return "Geben Sie die Vordergrundfarbei für diese Zelle ein."
            Case RadGridStringId.ConditionalFormattingPropertyGridEnabledDescription
                Return "Legt fest, ob diese Bedingung aktiviert ist (can be evaluated and applied)."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowBackColorDescription
                Return "Geben Sie die Hintergrundfarbe für die gesamte Zeile ein."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowForeColorDescription
                Return "Geben Sie die Vordergrundfarbe für die gesamte Zeile ein."
            Case RadGridStringId.ConditionalFormattingPropertyGridRowTextAlignmentDescription
                Return "Geben Sie die Textausrichtung für diese Zellen an, wenn ApplyToRow wahr ist."
            Case RadGridStringId.ConditionalFormattingPropertyGridTextAlignmentDescription
                Return "Geben Sie die Textausrichtung für diese Zellen an."

            Case RadGridStringId.ColumnChooserFormCaption
                Return "Spalte wählen"
            Case RadGridStringId.ColumnChooserFormMessage
                Return "Ziehen Sie eine Spaltenüberschrift aus der Tabelle" & vbLf & "hierhin, um sie aus aus der aktuellen Tabellenansicht" & vbLf & "zu entfernen."
            Case RadGridStringId.GroupingPanelDefaultMessage
                Return "Ziehen Sie eine Tabelle hierher, um sie zu gruppieren."
            Case RadGridStringId.GroupingPanelHeader
                Return "Gruppiert nach:"
            Case RadGridStringId.PagingPanelPagesLabel
                Return "Seite"
            Case RadGridStringId.PagingPanelOfPagesLabel
                Return "von"
            Case RadGridStringId.NoDataText
                Return "Keine Daten vorhanden"
            Case RadGridStringId.CompositeFilterFormErrorCaption
                Return "Filter Error"
            Case RadGridStringId.CompositeFilterFormInvalidFilter
                Return "The composite filter descriptor is not valid."

            Case RadGridStringId.ExpressionMenuItem
                Return "Ausdruck"
            Case RadGridStringId.ExpressionFormTitle
                Return "Expression Builder"
            Case RadGridStringId.ExpressionFormFunctions
                Return "Funktionen"
            Case RadGridStringId.ExpressionFormFunctionsText
                Return "Text"
            Case RadGridStringId.ExpressionFormFunctionsAggregate
                Return "Verknüpfen"
            Case RadGridStringId.ExpressionFormFunctionsDateTime
                Return "Date-Time"
            Case RadGridStringId.ExpressionFormFunctionsLogical
                Return "Logical"
            Case RadGridStringId.ExpressionFormFunctionsMath
                Return "Math"
            Case RadGridStringId.ExpressionFormFunctionsOther
                Return "Other"
            Case RadGridStringId.ExpressionFormOperators
                Return "Operators"
            Case RadGridStringId.ExpressionFormConstants
                Return "Constants"
            Case RadGridStringId.ExpressionFormFields
                Return "Fields"
            Case RadGridStringId.ExpressionFormDescription
                Return "Description"
            Case RadGridStringId.ExpressionFormResultPreview
                Return "Result preview"
            Case RadGridStringId.ExpressionFormTooltipPlus
                Return "Plus"
            Case RadGridStringId.ExpressionFormTooltipMinus
                Return "Minus"
            Case RadGridStringId.ExpressionFormTooltipMultiply
                Return "Multiply"
            Case RadGridStringId.ExpressionFormTooltipDivide
                Return "Divide"
            Case RadGridStringId.ExpressionFormTooltipModulo
                Return "Modulo"
            Case RadGridStringId.ExpressionFormTooltipEqual
                Return "Equal"
            Case RadGridStringId.ExpressionFormTooltipNotEqual
                Return "Not Equal"
            Case RadGridStringId.ExpressionFormTooltipLess
                Return "Less"
            Case RadGridStringId.ExpressionFormTooltipLessOrEqual
                Return "Less Or Equal"
            Case RadGridStringId.ExpressionFormTooltipGreaterOrEqual
                Return "Greater Or Equal"
            Case RadGridStringId.ExpressionFormTooltipGreater
                Return "Greater"
            Case RadGridStringId.ExpressionFormTooltipAnd
                Return "Logical ""AND"""
            Case RadGridStringId.ExpressionFormTooltipOr
                Return "Logical ""OR"""
            Case RadGridStringId.ExpressionFormTooltipNot
                Return "Logical ""NOT"""
            Case RadGridStringId.ExpressionFormAndButton
                Return String.Empty
                'if empty, default button image is used
            Case RadGridStringId.ExpressionFormOrButton
                Return String.Empty
                'if empty, default button image is used
            Case RadGridStringId.ExpressionFormNotButton
                Return String.Empty
                'if empty, default button image is used
            Case RadGridStringId.ExpressionFormOKButton
                Return "OK"
            Case RadGridStringId.ExpressionFormCancelButton
                Return "Cancel"
        End Select

        Return String.Empty
    End Function
End Class
