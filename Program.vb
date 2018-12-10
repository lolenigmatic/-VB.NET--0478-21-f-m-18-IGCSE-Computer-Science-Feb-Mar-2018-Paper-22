Imports System

Module Program
    Sub Main(args As String())
        'Init
        'all arrays starting with student are parallel
        'subject names and subject count are parallel
        Const totalStudents As Integer = 60
        Dim studentNames(totalStudents - 1) As String
        Dim userInput As String
        Dim studentChoice1(totalStudents - 1) As String
        Dim studentChoice2(totalStudents - 1) As String
        Dim subjectNames() As String = {"physics", "chemistry", "history", "geography", "computer science"}
        Dim subjectCounts(4) As Integer 'Passive count for task 1 only

        'TASK 1 - INPUT STUDENT INFO AND COUNT HOW MANY STUDENTS HAVE CHOSEN EACH SUBJECT

        'Input loop for all students
        For i = 0 To studentNames.Length - 1
            Console.WriteLine("Please enter student name:")
            studentNames(i) = Console.ReadLine

            'For 2 subject choices
            For j = 1 To 2
                Console.WriteLine("Please enter subject choice " & j)
                Console.WriteLine("1. Physics")
                Console.WriteLine("2. Chemistry")
                Console.WriteLine("3. History")
                Console.WriteLine("4. Geography")
                Console.WriteLine("5. Computer Science")
                userInput = Console.ReadLine
                'Adding to subjectChoice arrays
                If j = 1 Then
                    studentChoice1(i) = subjectNames(userInput - 1)
                    subjectCounts(userInput - 1) += 1
                Else
                    studentChoice2(i) = subjectNames(userInput - 1)
                    subjectCounts(userInput - 1) += 1
                End If
            Next
        Next

        'Outputting each subjects counts
        For i = 0 To subjectCounts.Length - 1
            Console.WriteLine("Amount of people who chose " & subjectNames(i) & ": " & subjectCounts(i))
        Next

        'TASK 2 - ALLOCATE STUDENTS TO GROUPS AND IDENTIFY PROBLEMS

        'Init vars for task 2
        Const maxStudentsPerGroup As Integer = 20
        Dim studentSubjectsConfirmed(59) As Integer

        'Subject count, and group arrays
        Dim physCount As Integer = 0
        Dim physGroup1(maxStudentsPerGroup - 1) As String
        Dim physGroup2(maxStudentsPerGroup - 1) As String

        Dim chemCount As Integer = 0
        Dim chemGroup1(maxStudentsPerGroup - 1) As String
        Dim chemGroup2(maxStudentsPerGroup - 1) As String

        Dim histCount As Integer = 0
        Dim histGroup1(maxStudentsPerGroup - 1) As String
        Dim histGroup2(maxStudentsPerGroup - 1) As String

        Dim geoCount As Integer = 0
        Dim geoGroup1(maxStudentsPerGroup - 1) As String
        Dim geoGroup2(maxStudentsPerGroup - 1) As String

        Dim csCount As Integer = 0
        Dim csGroup1(maxStudentsPerGroup - 1) As String
        Dim csGroup2(maxStudentsPerGroup - 19) As String

        'Allocating students to groups
        For i = 0 To studentNames.Length - 1

            'Explanation for this code
            'This could have been a lot easier, but you cannot f***ing append to arrays in VB.NET
            'I will have a running count for how much students have chosen physics SO FAR, this count will increase as the loop goes on.
            'This is so that I will add to the right index of the group array.
            'There will be 2 groups if more than 20 students choose a group, this is taken care in the if statement If physCount <= maxstudentsPerGroup - 1
            'The studentSubjectConfirmed array is to identify students who have failed to join a subject group, and now has less than 2 extra subjects.
            'The if statement comparing subjectCounts(i) to 20 is to take care of undersubscription
            'Hypothetical and unused groups will be generated if undersubscription happens, I don't want to handle that.
            'If oversubscription happens, studentSubjectsConfirmed will not be incremented, this will lead that students index to be 1 or 0, which will be outputted later.

            If studentChoice1(i) = "physics" Then
                If physCount <= maxStudentsPerGroup - 1 Then
                    physGroup1(physCount) = studentNames(i)
                    If subjectCounts(0) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    physCount += 1
                ElseIf physCount <= (maxStudentsPerGroup * 2) - 1 Then
                    physGroup2(physCount - 20) = studentNames(i)
                    If subjectCounts(0) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    physCount += 1
                End If
            End If
            If studentChoice2(i) = "physics" Then
                If physCount <= maxStudentsPerGroup - 1 Then
                    physGroup1(physCount) = studentNames(i)
                    If subjectCounts(0) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    physCount += 1
                ElseIf physCount <= (maxStudentsPerGroup * 2) - 1 Then
                    physGroup2(physCount - 20) = studentNames(i)
                    If subjectCounts(0) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    physCount += 1
                End If

            End If

            If studentChoice1(i) = "chemistry" Then
                If chemCount <= maxStudentsPerGroup - 1 Then
                    chemGroup1(chemCount) = studentNames(i)
                    If subjectCounts(1) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    chemCount += 1
                ElseIf chemCount <= (maxStudentsPerGroup * 2) - 1 Then
                    physGroup2(physCount - 20) = studentNames(i)
                    If subjectCounts(1) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    chemCount += 1
                End If

            End If
            If studentChoice2(i) = "chemistry" Then
                If chemCount <= maxStudentsPerGroup - 1 Then
                    chemGroup1(chemCount) = studentNames(i)
                    If subjectCounts(1) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    chemCount += 1
                ElseIf chemCount <= (maxStudentsPerGroup * 2) - 1 Then
                    chemGroup2(chemCount - 20) = studentNames(i)
                    If subjectCounts(1) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    chemCount += 1
                End If

            End If

            If studentChoice1(i) = "history" Then
                If histCount <= maxStudentsPerGroup - 1 Then
                    histGroup1(histCount) = studentNames(i)
                    If subjectCounts(2) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    histCount += 1
                ElseIf histCount <= (maxStudentsPerGroup * 2) - 1 Then
                    histGroup2(histCount - 20) = studentNames(i)
                    If subjectCounts(2) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    histCount += 1
                End If

            End If
            If studentChoice2(i) = "history" Then
                If histCount <= maxStudentsPerGroup - 1 Then
                    histGroup1(histCount) = studentNames(i)
                    If subjectCounts(2) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    histCount += 1
                ElseIf histCount <= (maxStudentsPerGroup * 2) - 1 Then
                    histGroup2(histCount - 20) = studentNames(i)
                    If subjectCounts(2) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    histCount += 1
                End If

            End If

            If studentChoice1(i) = "geography" Then
                If geoCount <= maxStudentsPerGroup - 1 Then
                    geoGroup1(geoCount) = studentNames(i)
                    If subjectCounts(3) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    geoCount += 1
                ElseIf geoCount <= (maxStudentsPerGroup * 2) - 1 Then
                    geoGroup2(geoCount - 20) = studentNames(i)
                    If subjectCounts(3) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    geoCount += 1
                End If

            End If
            If studentChoice2(i) = "geography" Then
                If geoCount <= maxStudentsPerGroup - 1 Then
                    geoGroup1(geoCount) = studentNames(i)
                    If subjectCounts(3) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    geoCount += 1
                ElseIf geoCount <= (maxStudentsPerGroup * 2) - 1 Then
                    geoGroup2(geoCount - 20) = studentNames(i)
                    If subjectCounts(3) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    geoCount += 1
                End If

            End If

            If studentChoice1(i) = "computer science" Then
                If csCount <= maxStudentsPerGroup - 1 Then
                    csGroup1(csCount) = studentNames(i)
                    If subjectCounts(4) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    csCount += 1
                ElseIf csCount <= (maxStudentsPerGroup * 2) - 1 Then
                    csGroup2(csCount - 20) = studentNames(i)
                    If subjectCounts(4) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    csCount += 1
                End If

            End If
            If studentChoice2(i) = "computer science" Then
                If csCount <= maxStudentsPerGroup - 1 Then
                    csGroup1(csCount) = studentNames(i)
                    If subjectCounts(4) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    csCount += 1
                ElseIf csCount <= (maxStudentsPerGroup * 2) - 1 Then
                    csGroup2(csCount - 20) = studentNames(i)
                    If subjectCounts(4) >= 10 Then
                        studentSubjectsConfirmed(i) += 1
                    End If
                    csCount += 1
                End If

            End If

        Next

        'Identifying oversubscription and undersubscription, while also outputting subject groups.
        If subjectCounts(0) < 10 Then
            Console.WriteLine("Physics will not run this year due to undersubscription")
        ElseIf subjectCounts(0) > 40 Then
            Console.WriteLine("Physics is oversubscribed and some students will not be able to join.")
        End If

        If subjectCounts(1) < 10 Then
            Console.WriteLine("Chemistry will not run this year due to undersubscription")
        ElseIf subjectCounts(1) > 40 Then
            Console.WriteLine("Chemistry is oversubscribed and some students will not be able to join.")
        End If

        If subjectCounts(2) < 10 Then
            Console.WriteLine("History will not run this year due to undersubscription")
        ElseIf subjectCounts(2) > 40 Then
            Console.WriteLine("History is oversubscribed and some students will not be able to join.")
        End If

        If subjectCounts(3) < 10 Then
            Console.WriteLine("Geography will not run this year due to undersubscription")
        ElseIf subjectCounts(3) > 40 Then
            Console.WriteLine("Geography is oversubscribed and some students will not be able to join.")
        End If

        If subjectCounts(4) < 10 Then
            Console.WriteLine("Computer Science will not run this year due to undersubscription")
        ElseIf subjectCounts(4) > 40 Then
            Console.WriteLine("Computer Science is oversubscribed and some students will not be able to join.")
        End If

        If physCount >= 10 Then
            Console.WriteLine("Physics Group 1:")
            For j = 0 To physGroup1.Length - 1
                Console.WriteLine(physGroup1(j))
            Next

            Console.WriteLine("Physics Group 2 (if none, there will not be a second group)")
            For j = 0 To physGroup2.Length - 1
                Console.WriteLine(physGroup2(j))
            Next

        End If

        If chemCount >= 10 Then
            Console.WriteLine("Chemistry Group 1:")
            For j = 0 To chemGroup1.Length - 1
                Console.WriteLine(chemGroup1(j))
            Next

            Console.WriteLine("Chemistry Group 2 (if none, there will not be a second group)")
            For j = 0 To chemGroup2.Length - 1
                Console.WriteLine(chemGroup2(j))
            Next

        End If

        If histCount >= 10 Then
            Console.WriteLine("History Group 1:")
            For j = 0 To histGroup1.Length - 1
                Console.WriteLine(histGroup1(j))
            Next

            Console.WriteLine("History Group 2 (if none, there will not be a second group)")
            For j = 0 To histGroup2.Length - 1
                Console.WriteLine(histGroup2(j))
            Next

        End If

        If geoCount >= 10 Then
            Console.WriteLine("Geography Group 1:")
            For j = 0 To geoGroup1.Length - 1
                Console.WriteLine(geoGroup1(j))
            Next

            Console.WriteLine("Geography Group 2 (if none, there will not be a second group)")
            For j = 0 To geoGroup2.Length - 1
                Console.WriteLine(geoGroup2(j))
            Next

        End If

        If csCount >= 10 Then
            Console.WriteLine("Computer Science Group 1:")
            For j = 0 To csGroup1.Length - 1
                Console.WriteLine(csGroup1(j))
            Next

            Console.WriteLine("Computer Science Group 2 (if none, there will not be a second group)")
            For j = 0 To csGroup2.Length - 1
                Console.WriteLine(csGroup2(j))
            Next

        End If

        Console.WriteLine("Students who have been allocated only 1 subject: ")
        For j = 0 To studentSubjectsConfirmed.Length - 1
            If studentSubjectsConfirmed(j) = 1 Then
                Console.WriteLine(studentNames(j))
            End If
        Next

        Console.WriteLine("Students who have been allocated no subject:")
        For j = 0 To studentSubjectsConfirmed.Length - 1
            If studentSubjectsConfirmed(j) = 0 Then
                Console.WriteLine(studentNames(j))
            End If
        Next

        'TASK 3 - SHOWING WHETHER OR NOT THE SPARE SPACES IN SUBJECT GROUPS CAN BE FILLED.
        Dim subjectCountsFinal() As Integer = {physCount, chemCount, histCount, geoCount, csCount}
        Dim spareTotal As Integer = 0
        Dim unallocatedTotal As Integer = 0
        Console.WriteLine("Calculating spare spaces...")
        'If larger than 40, there will be 2 groups, therefore take away from 40
        'If lower than 10, subject will not be available, therefore 0 spares
        'Else, size is 10 - 20, so subject will be 1group, take away from 40

        For i = 0 To subjectCountsFinal.Length - 1
            If subjectCountsFinal(i) > 20 Then
                spareTotal += 40 - subjectCountsFinal(i)
            ElseIf subjectCountsFinal(i) < 10 Then
                spareTotal += 0
            Else
                spareTotal += 20 - subjectCountsFinal(i)
            End If
        Next

        For i = 0 To studentSubjectsConfirmed.Length - 1
            unallocatedTotal += 2 - studentSubjectsConfirmed(i)
        Next

        Console.WriteLine("There are " & unallocatedTotal & " unallocated students.")
        Console.WriteLine("There are " & spareTotal & " spare places in subject groups.")
        If unallocatedTotal > spareTotal Then
            Console.WriteLine("There are too many unallocated students to cover the spare places.")
        Else
            Console.WriteLine("There amount of unallocated students will be able to cover the spare places.")
        End If

        Console.ReadLine()
    End Sub
End Module
