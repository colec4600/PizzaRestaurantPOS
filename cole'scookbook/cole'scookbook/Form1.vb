Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CookbookDataSet.Ingredient' table. You can move, or remove it, as needed.
        Me.IngredientTableAdapter.Fill(Me.CookbookDataSet.Ingredient)

    End Sub

    Private Sub IngredientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IngredientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IngredientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CookbookDataSet)

    End Sub
End Class
