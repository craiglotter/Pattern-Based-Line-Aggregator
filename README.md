Pattern Based Line Aggregator
=============================

Pattern Based Line Aggregator simply parses an input file, matching each text line against the user specified pattern. If the result is true and the aggregator option was chosen then that line is written to the new text file. If the result is true and the removal option was chosen then that line is removed from the resulting file.

For example, with a pattern of 'Test' and the 'aggregate' option selected:
test01
text01
Test01
Test02

will yield:
Test01
Test02

Created by Craig Lotter, April 2006

*********************************

Project Details:

Coded in Visual Basic .NET using Visual Studio .NET 2006
Implements concepts such as threading and text file manipulation.
Level of Complexity: simple
