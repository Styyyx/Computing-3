import tkinter as tk
import SolutionWindow as sw

class MainWindow(tk.Frame):
  def __init__(self, master=None):
    tk.Frame.__init__(self, master=None)
    self.screen = {'width': self.master.winfo_screenwidth(), 'height' : self.master.winfo_screenheight()}
    self.MasterSettings()
    self.CreateWidgets()

  def MasterSettings(self):
    self.master.geometry(
      f"400x300+{int((self.screen['width']-400)/2)}+{int((self.screen['height']-300)/2)}"
    )
    self.master.title('Computing')
    self.master.resizable(width=False, height=False)
    self.master.columnconfigure(0, weight=1)
    self.master.columnconfigure(1, weight=1)
    self.master.columnconfigure(2, weight=1)
    self.master.columnconfigure(3, weight=1)

  def CreateWidgets(self):
    self.labelTitle = tk.Label(
      master=self.master,
      text='Solve independent linear system using Row-Echelon Form',
      wraplength=300,
      justify='center',
      font=('Arial', 14)
    ).grid(pady=20, row=0, columnspan=4)

    self.labelMatrixSize = tk.Label(
      master=self.master,
      text='Enter size of matrix:',
      font=('Arial', 12)
    ).grid(pady=20, row=2, columnspan=4)

    self.entryRows = tk.Entry(
      master=self.master,
      font=('Arial', 12),
      width=4,
    ).grid(row=3, column=1, columnspan=1, sticky=tk.E, padx=(0,10))

    self.entryColumns = tk.Entry(
      master=self.master,
      font=('Arial', 12),
      width=4,
    ).grid(row=3, column=2, columnspan=1, sticky=tk.W, padx=(10,0))

    self.btnCreate = tk.Button(
      master=self.master,
      command=CreateMatrix,
      text='Create Matrix'
    ).grid(row=4, column=1, columnspan=2, pady=(20,0))

  # btnCreate Event Handler
  def CreateMatrix(self):
    row = int(self.entryRows.get())
    col = int(self.entryColumns.get())
    
