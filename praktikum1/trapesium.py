from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W


class FrmTrapesium:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x400")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        # pasang Label
        Label(mainFrame, text='Alas a :').grid(
            row=0, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Alas b :').grid(
            row=1, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Tinggi :').grid(
            row=2, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi a:').grid(
            row=3, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi b:').grid(
            row=4, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi c:').grid(
            row=5, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi d:').grid(
            row=6, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas :").grid(
            row=8, column=0, sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling :").grid(
            row=9, column=0, sticky=W, padx=5, pady=5)
        # pasang textbox
        self.txtalasa = Entry(mainFrame)
        self.txtalasa.grid(row=0, column=1, padx=5, pady=5)
        self.txtalasb = Entry(mainFrame)
        self.txtalasb.grid(row=1, column=1, padx=5, pady=5)
        self.txttinggi = Entry(mainFrame)
        self.txttinggi.grid(row=2, column=1, padx=5, pady=5)
        self.txtsisia = Entry(mainFrame)
        self.txtsisia.grid(row=3, column=1, padx=5, pady=5)
        self.txtsisib = Entry(mainFrame)
        self.txtsisib.grid(row=4, column=1, padx=5, pady=5)
        self.txtsisic = Entry(mainFrame)
        self.txtsisic.grid(row=5, column=1, padx=5, pady=5)
        self.txtsisid = Entry(mainFrame)
        self.txtsisid.grid(row=6, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=8, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=9, column=1, padx=5, pady=5)
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
                                command=self.onHitung)
        self.btnHitung.grid(row=7, column=1, padx=5, pady=5)
        # fungsi untuk menghitung luas dan keliling persegi panjang

    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Terstruktur
        alasa = int(self.txtalasa.get())
        alasb = int(self.txtalasb.get())
        tinggi = int(self.txttinggi.get())
        sisia = int(self.txtsisia.get())
        sisib = int(self.txtsisib.get())
        sisic = int(self.txtsisic.get())
        sisid = int(self.txtsisid.get())
        luas, kel = self.trapesium(
            alasa, alasb, tinggi, sisia, sisib, sisic, sisid)

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(kel))

    def trapesium(self, alasa, alasb, tinggi, sisia, sisib, sisic, sisid):
        luas = 1/2 * (alasa + alasb) * tinggi
        kel = sisia + sisib + sisic + sisid
        return luas, kel

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()


if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmTrapesium(root, "Program Luas dan Keliling Trapesium")
    root.mainloop()
