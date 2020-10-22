import tkinter as tk

class SolutionWindow(tk.Toplevel):
  def __init__(self, size, master=None):
    tk.Toplevel.__init__(self, master=None)
    self.master.title('New Window')
