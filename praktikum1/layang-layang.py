from tkinter import Frame, Label, Entry, Button, YES, BOTH, END, Tk, W


class FrmLayang:
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
        Label(mainFrame, text='Diagonal 1 :').grid(row=0, column=0,
                                                   sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Diagonal 2 :').grid(row=1, column=0,
                                                   sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi Pendek Layang :').grid(row=2, column=0,
                                                           sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi Panjang Layang :').grid(row=3, column=0,
                                                            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas:").grid(row=5, column=0,
                                            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling:").grid(row=6, column=0,
                                                sticky=W, padx=5, pady=5)
        # pasang textbox
        self.txtdiagonal1 = Entry(mainFrame)
        self.txtdiagonal1.grid(row=0, column=1, padx=5, pady=5)
        self.txtdiagonal2 = Entry(mainFrame)
        self.txtdiagonal2.grid(row=1, column=1, padx=5, pady=5)
        self.txtsisipen = Entry(mainFrame)
        self.txtsisipen.grid(row=2, column=1, padx=5, pady=5)
        self.txtsisipan = Entry(mainFrame)
        self.txtsisipan.grid(row=3, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=5, column=1, padx=5, pady=5)
        self.txtKeliling = Entry(mainFrame)
        self.txtKeliling.grid(row=6, column=1, padx=5, pady=5)
        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
                                command=self.onHitung)
        self.btnHitung.grid(row=4, column=1, padx=5, pady=5)
        # fungsi untuk menghitung luas dan keliling persegi panjang

    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Terstruktur
        d1 = int(self.txtdiagonal1.get())
        d2 = int(self.txtdiagonal2.get())
        sipen = int(self.txtsisipen.get())
        sipan = int(self.txtsisipan.get())
        luas, kel = self.layang(d1, d2, sipen, sipan)

        self.txtLuas.delete(0, END)
        self.txtLuas.insert(END, str(luas))
        self.txtKeliling.delete(0, END)
        self.txtKeliling.insert(END, str(kel))

    def layang(self, d1, d2, sipen, sipan):
        luas = 1/2 * (d1*d2)
        kel = 2 * (sipen * sipan)
        return luas, kel

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()


if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmLayang(root, "Program Luas dan Keliling Layang Layang")
    root.mainloop()
