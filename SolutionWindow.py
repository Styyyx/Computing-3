import tkinter as tk

class SolutionWindow(tk.Toplevel):
  def __init__(self, size, master=None):
    tk.Toplevel.__init__(self, master=None)
    self.rowSize, self.colSize = size
    self.matrix = []

    self.InitializeSelf()
    self.CreateWidgets()

  def InitializeSelf(self):
    self.title('Solve Linear System with Row Echelon Form')
    self.geometry('')
    self.protocol('WM_DELETE_WINDOW', self.OnExit)
    for row in range(1, 5+self.rowSize):
      self.master.rowconfigure(row, weight=1)
    for col in range(self.colSize):
      self.master.columnconfigure(col,weight=1)

  # Create Initial Widgets
  def CreateWidgets(self):
    self.labSize = tk.Label(
      master=self,
      text= f'Matrix Size: {self.rowSize} X {self.colSize}'
    ).grid(pady=(10,20), row=0, column=0)

    self.btnSolve = tk.Button(
      master=self,
      command=self.SolveMatrix,
      text='Solve'
    ).grid(
        pady=(10,0),
        row=(self.rowSize + 3),
        column=(self.colSize/4),
        columnspan=(self.colSize/2)
      )

  def SolveMatrix(self):
    pass

  def FillWithZero(self):
    pass
  
  def ClearMatrix(self):
    pass

  def OnExit(self):
    self.master.destroy()