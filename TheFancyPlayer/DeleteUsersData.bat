@echo off

for /f %%a in ('dir c:\users /b') do (
  rd c:\users\%%a\AppData\Roaming\TheFancyPlayer/s /q
  )





