Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Drawing

# ======== 起動時に全半比較.exeを実行 ========
$exePath = "C:\Program Files (x86)\Project1\全半比較.exe"
Start-Process -FilePath $exePath

# ======== フォーム設定 ========
$form = New-Object System.Windows.Forms.Form
$form.Text = "COMポート一覧ツール"
$form.Width = 400
$form.Height = 300
$form.StartPosition = "CenterScreen"

# ======== ラベル ========
$label = New-Object System.Windows.Forms.Label
$label.Text = "利用可能なポート一覧:"
$label.AutoSize = $true
$label.Top = 10
$label.Left = 10
$form.Controls.Add($label)

# ======== テキストボックス（一覧表示） ========
$textBox = New-Object System.Windows.Forms.TextBox
$textBox.Multiline = $true
$textBox.ReadOnly = $true
$textBox.ScrollBars = "Vertical"
$textBox.Width = 350
$textBox.Height = 160
$textBox.Top = 35
$textBox.Left = 10
$form.Controls.Add($textBox)

# ======== 更新ボタン ========
$btnRefresh = New-Object System.Windows.Forms.Button
$btnRefresh.Text = "更新"
$btnRefresh.Width = 100
$btnRefresh.Top = 210
$btnRefresh.Left = 60
$form.Controls.Add($btnRefresh)

# ======== 終了ボタン ========
$btnClose = New-Object System.Windows.Forms.Button
$btnClose.Text = "終了"
$btnClose.Width = 100
$btnClose.Top = 210
$btnClose.Left = 200
$form.Controls.Add($btnClose)

# ======== ポート一覧更新関数 ========
function Refresh-PortList {
    $ports = [System.IO.Ports.SerialPort]::GetPortNames()
    if ($ports.Count -eq 0) {
        $textBox.Text = "利用可能なポートはありません。"
    }
    else {
        $textBox.Text = "現在利用可能なポート:`r`n" + ($ports -join "`r`n")
    }
}

# ======== イベント設定 ========
$btnRefresh.Add_Click({ Refresh-PortList })
$btnClose.Add_Click({ $form.Close() })

# ======== 初期表示 ========
Refresh-PortList

# ======== フォーム表示 ========
[void]$form.ShowDialog()

