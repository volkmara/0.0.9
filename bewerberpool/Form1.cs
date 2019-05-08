

// Originalulas in Listbox einlesen
private void ulaseinlesen()
{
    if (Module1.connectionString.Contains("127.0.0.1"))
        Module1.verzeichnis = System.Convert.ToString(@"e:\heyduck\ulas\");
    else
        Module1.verzeichnis = System.Convert.ToString(@"x:\ulas\");

    ulasoriginalverzeichnis = string.Concat(Module1.verzeichnis, Module1.letzteid, @"\Originale\");
    UlasListBox.Items.Clear();
    if (System.IO.Directory.Exists(ulasoriginalverzeichnis))
    {
        var ll = new List<System.IO.FileInfo>();
        ll.AddRange(new System.IO.DirectoryInfo(ulasoriginalverzeichnis).GetFiles("*.*", SearchOption.AllDirectories));

        foreach (FileInfo Item in ll)
        {
            string listitem = string.Concat(ulasoriginalverzeichnis, Item.ToString());
            UlasListBox.Items.Add(listitem);
        }
    }
    else
    {
        // UlasListBox.DataSource = Nothing
        UlasListBox.Items.Clear();
        return;
    }
}
