Imports System

Module Program
    Public Function titulo()
        Dim Fecha As String
        Fecha = Format(Now(), "General Date")
        'ENCABEZADO'
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|                                     Colegio Belén                             |")
        Console.WriteLine("|                      Aplicación para el registro de calificaciones            |")
        Console.WriteLine("|                                                                               |")
        Console.WriteLine("|         Ubicación: Calle F Sur, Barrio El Carmen, Calle Miguel A. Brenes.     |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|                 Todos los derechos reservados a: XAT Software  2022           |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|                           " & Fecha & "                            |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
    End Function

    Sub Main(args As String())
        Dim control, control2, control3, control4, control5, control6 As Boolean
        Dim cantidadEstu, contador, contador2, cantidadNDiara, cantidadNApreci As Integer
        Dim materia, profe As String
        Console.ForegroundColor = ConsoleColor.Cyan
        titulo()
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|    Por favor ingrese el nombre de la materia    :                             |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        materia = Console.ReadLine()
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|    Por favor ingrese el nombre del profesor    :                              |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        profe = Console.ReadLine()
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Console.WriteLine("|    Por favor ingrese la cantidad de estudiantes :                             |")
        Console.WriteLine("|-------------------------------------------------------------------------------|")
        Do While (control = False)
            Try
                cantidadEstu = Console.ReadLine
                control = True
                Dim cedula(cantidadEstu) As String 'Se genera el arreglo para las cedulas de los estudiantes'
                Dim acumularNDiarias(cantidadEstu), acumularNApreci(cantidadEstu), nExamenF(cantidadEstu), notaF(cantidadEstu) As Double
                Console.WriteLine("|-------------------------------------------------------------------------------|")
                Console.WriteLine("|    Por favor ingrese la cantidad de notas diarias :                           |")
                Console.WriteLine("|-------------------------------------------------------------------------------|")
                Do While (control2 = False)
                    Try
                        cantidadNDiara = Console.ReadLine()
                        control2 = True
                        Do While (cantidadNDiara < 4 Or cantidadNDiara > 6) 'Control para la cantidad de notas diarias'
                            Console.WriteLine("Ingrese una cantidad de notas valida. Entre 4 y 6")
                            cantidadNDiara = Console.ReadLine()
                        Loop
                    Catch ex As Exception
                        Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
                    End Try
                Loop
                Console.WriteLine("|-------------------------------------------------------------------------------|")
                Console.WriteLine("|    Por favor ingrese la cantidad de notas de apreciacion :                    |")
                Console.WriteLine("|-------------------------------------------------------------------------------|")
                Do While (control4 = False)
                    Try
                        cantidadNApreci = Console.ReadLine()
                        control4 = True
                        Do While (cantidadNApreci < 3 Or cantidadNApreci > 5) 'Control para la cantidad de notas diarias'
                            Console.WriteLine("Ingrese una cantidad de notas valida. Entre 3 y 5")
                            cantidadNApreci = Console.ReadLine()
                        Loop
                    Catch ex As Exception
                        Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
                    End Try
                Loop
                Dim nDiaria(cantidadEstu, cantidadNDiara + cantidadNApreci) As Double 'Se genera el arreglo de las notas diarias'
                Dim nApreci(cantidadEstu, cantidadNApreci) As Double 'Se genera el arreglo de las notas de apreciacion'
                Console.Clear()
                For contador = 1 To cantidadEstu
                    Console.WriteLine("|-------------------------------------------------------------------------------|")
                    Console.WriteLine("|    Por favor ingrese la cedula del estudiante :                               |")
                    Console.WriteLine("|-------------------------------------------------------------------------------|")
                    cedula(contador) = Console.ReadLine()
                    Console.WriteLine("|-------------------------------------------------------------------------------|")
                    Console.WriteLine("|    Por favor ingrese las notas diarias del estudiante  :                      |")
                    Console.WriteLine("|-------------------------------------------------------------------------------|")
                    For contador2 = 1 To cantidadNDiara
                        Do While (control3 = False)
                            Try
                                nDiaria(contador, contador2) = Console.ReadLine()
                                control3 = True
                                Do While (nDiaria(contador, contador2) < 1 Or nDiaria(contador, contador2) > 5) 'Control para las de notas'
                                    Console.WriteLine("Ingrese una nota valida. Entre 1.0 y 5.0")
                                    nDiaria(contador, contador2) = Console.ReadLine()
                                Loop
                                acumularNDiarias(contador) += nDiaria(contador, contador2)
                            Catch ex As Exception
                                Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
                            End Try
                        Loop
                        control3 = False
                    Next
                    Console.WriteLine("|-------------------------------------------------------------------------------|")
                    Console.WriteLine("|    Por favor ingrese las notas de apreciacion del estudiante:                 |")
                    Console.WriteLine("|-------------------------------------------------------------------------------|")
                    For contador2 = 1 To cantidadNApreci
                        Do While (control5 = False)
                            Try
                                nApreci(contador, contador2) = Console.ReadLine()
                                control5 = True
                                Do While (nApreci(contador, contador2) < 1 Or nApreci(contador, contador2) > 5) 'Control para las de notas'
                                    Console.WriteLine("Ingrese una nota valida. Entre 1.0 y 5.0")
                                    nApreci(contador, contador2) = Console.ReadLine()
                                Loop
                                acumularNApreci(contador) += nApreci(contador, contador2)
                            Catch ex As Exception
                                Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
                            End Try
                        Loop
                        control5 = False
                    Next
                    Console.WriteLine("|-------------------------------------------------------------------------------|")
                    Console.WriteLine("|    Por favor ingrese las notas del examen final del estudiante:               |")
                    Console.WriteLine("|-------------------------------------------------------------------------------|")
                    Do While (control6 = False)
                        Try
                            nExamenF(contador) = Console.ReadLine()
                            Do While (nExamenF(contador) < 1 Or nExamenF(contador) > 5) 'Control para las notas'
                                Console.WriteLine("Ingrese una nota valida. Entre 1.0 y 5.0")
                                nExamenF(contador) = Console.ReadLine()
                            Loop
                            control6 = True
                        Catch ex As Exception
                            Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
                        End Try
                    Loop
                    control6 = False
                    Console.Clear()
                Next
                For contador = 1 To cantidadEstu
                    notaF(contador) = ((acumularNApreci(contador) / cantidadNApreci) + (acumularNDiarias(contador) / cantidadNDiara) + nExamenF(contador)) / 3
                    notaF(contador) = Math.Round(notaF(contador), 2)
                Next
                Console.WriteLine("|---------------------------------------------------------------------------------------|")
                Console.WriteLine("|                          IMPRESION DE CALIFICACIONES                                  |")
                Console.WriteLine("|---------------------------------------------------------------------------------------|")
                Console.WriteLine("|************************************* Materia******************************************|")
                Console.WriteLine("|    " & materia.PadRight(89 - (Len(materia))) & " |")
                Console.WriteLine("|************************************* Profesor*****************************************|")
                Console.WriteLine("|    " & profe.PadRight(89 - (Len(profe))) & " |")
                Console.WriteLine("|---------------------------------------------------------------------------------------|")
                For contador = 1 To cantidadEstu
                    Console.WriteLine("|*************************************  Cedula *****************************************|")
                    Console.WriteLine("|    " & cedula(contador).PadRight(93 - (Len(cedula(contador)))) & "|")
                    Console.WriteLine("|************************************ Notas Diarias ************************************|")
                    For contador2 = 1 To (cantidadNDiara)
                        Console.WriteLine("|  " & contador2 & ".  " & CStr(nDiaria(contador, contador2)).PadRight(89 - (Len(nDiaria(contador, contador2)))) & "|")
                    Next
                    Console.WriteLine("|********************************* Notas de apreciacion ********************************|")
                    For contador2 = 1 To (cantidadNApreci)
                        Console.WriteLine("|  " & contador2 & ".  " & CStr(nApreci(contador, contador2)).PadRight(89 - (Len(nApreci(contador, contador2)))) & "|")
                    Next
                    Console.WriteLine("|******************************** Examen Final *****************************************|")
                    Console.WriteLine("|      " & CStr(nExamenF(contador)).PadRight(89 - (Len(nExamenF(contador)))) & "|")
                    Console.WriteLine("|******************************** Nota Final *******************************************|")
                    Console.WriteLine("|      " & CStr(notaF(contador)).PadRight(89 - (Len(notaF(contador)))) & "|")
                    Console.WriteLine("|---------------------------------------------------------------------------------------|")
                    Console.WriteLine(vbCrLf)
                Next

            Catch ex As Exception
                Console.WriteLine("ERROR!:El formato ingresado no es valido. Ingrese uno valido ")
            End Try
        Loop
    End Sub
End Module

