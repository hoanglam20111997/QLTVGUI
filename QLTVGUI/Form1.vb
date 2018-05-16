Imports QLTVBUS
Imports QLTVDTO
Imports Utility


Public Class lapthe

    Private docgia As laptheBUS
    Private ldgBus As loaidgBUS
    Private Sub btnnhap_Click(sender As Object, e As EventArgs) Handles btnnhap.Click
        Dim dg As laptheDTO
        dg = New laptheDTO()

        '1. Mapping data from GUI control
        dg.Madg = txtmadg.Text
        dg.Hoten = txthoten.Text
        dg.DiaChi = txtdiachi.Text
        dg.NgaySinh = datengaysinh.Value
        dg.Loaidocgia = Convert.ToInt32(intloaidocgia.SelectedValue)
        dg.Email = txtemail.Text
        dg.Ngaylapthe = datengaylap.Value
        dg.Nguoilap = txtnguoilap.Text

        '2. Business .....
        If (docgia.isValidName(dg) = False) Then
            MessageBox.Show("Họ tên độc giả không đúng")
            txthoten.Focus()
            Return
        End If
        If (docgia.isValidage(dg) = False) Then
            MessageBox.Show("Tuổi độc giả không đúngc(tuổi phải từ 18 đến 65)")
            datengaysinh.Focus()
            Return
        End If
        '3. Insert to DB

        Dim result As Result
        result = docgia.insert(dg)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMshs = "1"
            result = docgia.buildMSHS(nextMshs)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtmadg.Text = nextMshs
            txtdiachi.Text = String.Empty
            txthoten.Text = String.Empty

        Else
            MessageBox.Show("Thêm độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If


    End Sub
    Private Sub frmlapthehGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        docgia = New laptheBUS()
        ldgBus = New loaidgBUS()

        ' Load LoaiHocSinh list
        Dim listloaidg = New List(Of loaidgDTO)
        Dim result As Result
        result = ldgBus.selectAll(listloaidg)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        intloaidocgia.DataSource = New BindingSource(listloaidg, String.Empty)
        intloaidocgia.DisplayMember = "tenloaidg"
        intloaidocgia.ValueMember = "maloaidg"

        'set MSSH auto
        Dim nextMshs = "1"
        result = docgia.buildMSHS(nextMshs)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã Học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtmadg.Text = nextMshs

    End Sub
    Private Sub Lapthe(sender As Object, e As EventArgs) Handles MyBase.Load
        docgia = New laptheBUS()
    End Sub
End Class
