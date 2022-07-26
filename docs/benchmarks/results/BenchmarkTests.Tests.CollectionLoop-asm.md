## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForArray()
       sub       rsp,28
       xor       eax,eax
       xor       edx,edx
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rcx
       cmp       edx,[r8+8]
       jae       short M00_L02
       movsxd    r9,edx
       mov       r8,[r8+r9*8+10]
       add       eax,[r8+8]
       inc       edx
       cmp       [rcx+8],edx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 71
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForList()
       sub       rsp,28
       xor       eax,eax
       xor       edx,edx
       mov       rcx,[rcx+10]
       mov       r8,rcx
       mov       r8d,[r8+10]
       test      r8d,r8d
       jle       short M00_L01
M00_L00:
       mov       r9,rcx
       cmp       edx,r8d
       jae       short M00_L02
       mov       r9,[r9+8]
       cmp       edx,[r9+8]
       jae       short M00_L03
       movsxd    r10,edx
       mov       r9,[r9+r10*8+10]
       add       eax,[r9+8]
       inc       edx
       cmp       edx,r8d
       jl        short M00_L00
M00_L01:
       add       rsp,28
       ret
M00_L02:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 78
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachArray()
       xor       eax,eax
       mov       rdx,[rcx+8]
       xor       ecx,ecx
       mov       r8d,[rdx+8]
       test      r8d,r8d
       jle       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    r9,ecx
       mov       r9,[rdx+r9*8+10]
       add       eax,[r9+8]
       inc       ecx
       cmp       r8d,ecx
       jg        short M00_L00
M00_L01:
       ret
; Total bytes of code 52
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachList()
       sub       rsp,28
       xor       eax,eax
       mov       rdx,[rcx+10]
       mov       ecx,[rdx+14]
       mov       r8d,ecx
       xor       r9d,r9d
       jmp       short M00_L01
M00_L00:
       add       eax,[r10+8]
M00_L01:
       cmp       r8d,ecx
       jne       short M00_L04
       cmp       r9d,[rdx+10]
       jae       short M00_L02
       mov       r10,[rdx+8]
       cmp       r9d,[r10+8]
       jae       short M00_L05
       movsxd    r11,r9d
       mov       r10,[r10+r11*8+10]
       inc       r9d
       mov       r11d,1
       jmp       short M00_L03
M00_L02:
       mov       r9d,[rdx+10]
       inc       r9d
       xor       r10d,r10d
       xor       r11d,r11d
M00_L03:
       test      r11d,r11d
       jne       short M00_L00
       add       rsp,28
       ret
M00_L04:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 100
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumArray()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+8]
       mov       rcx,259180075C8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,259180075C0
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       [rdi+18],rdx
       mov       rcx,259180075C8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 127
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       eax,[rdx+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rdi,rdi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rsi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FF8ACB37CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
M02_L02:
       mov       r11,7FF8AC7203C0
       call      qword ptr [7FF8ACA803C0]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF8ACB37D78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       add       r14d,eax
       jo        short M02_L05
       mov       rcx,[rbp+0FFC8]
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7203C8
       call      qword ptr [7FF8ACA803C8]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7203C8
       call      qword ptr [7FF8ACA803C8]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 317
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumList()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+10]
       mov       rcx,1ED4DB075D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1ED4DB075C0
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       [rdi+18],rdx
       mov       rcx,1ED4DB075D0
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 127
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       eax,[rdx+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rdi,rdi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rsi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FF8ACB48038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
M02_L02:
       mov       r11,7FF8AC7303C0
       call      qword ptr [7FF8ACA903C0]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF8ACB48110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       add       r14d,eax
       jo        short M02_L05
       mov       rcx,[rbp+0FFC8]
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7303C8
       call      qword ptr [7FF8ACA903C8]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7303C8
       call      qword ptr [7FF8ACA903C8]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 317
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForArray()
       sub       rsp,28
       xor       eax,eax
       xor       edx,edx
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rcx
       cmp       edx,[r8+8]
       jae       short M00_L02
       movsxd    r9,edx
       mov       r8,[r8+r9*8+10]
       add       eax,[r8+8]
       inc       edx
       cmp       [rcx+8],edx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 71
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForList()
       sub       rsp,28
       xor       eax,eax
       xor       edx,edx
       mov       rcx,[rcx+10]
       mov       r8,rcx
       mov       r8d,[r8+10]
       test      r8d,r8d
       jle       short M00_L01
M00_L00:
       mov       r9,rcx
       cmp       edx,r8d
       jae       short M00_L02
       mov       r9,[r9+8]
       cmp       edx,[r9+8]
       jae       short M00_L03
       movsxd    r10,edx
       mov       r9,[r9+r10*8+10]
       add       eax,[r9+8]
       inc       edx
       cmp       edx,r8d
       jl        short M00_L00
M00_L01:
       add       rsp,28
       ret
M00_L02:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 78
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachArray()
       xor       eax,eax
       mov       rdx,[rcx+8]
       xor       ecx,ecx
       mov       r8d,[rdx+8]
       test      r8d,r8d
       jle       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    r9,ecx
       mov       r9,[rdx+r9*8+10]
       add       eax,[r9+8]
       inc       ecx
       cmp       r8d,ecx
       jg        short M00_L00
M00_L01:
       ret
; Total bytes of code 52
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachList()
       sub       rsp,28
       xor       eax,eax
       mov       rdx,[rcx+10]
       mov       ecx,[rdx+14]
       mov       r8d,ecx
       xor       r9d,r9d
       jmp       short M00_L01
M00_L00:
       add       eax,[r10+8]
M00_L01:
       cmp       r8d,ecx
       jne       short M00_L04
       cmp       r9d,[rdx+10]
       jae       short M00_L02
       mov       r10,[rdx+8]
       cmp       r9d,[r10+8]
       jae       short M00_L05
       movsxd    r11,r9d
       mov       r10,[r10+r11*8+10]
       inc       r9d
       mov       r11d,1
       jmp       short M00_L03
M00_L02:
       mov       r9d,[rdx+10]
       inc       r9d
       xor       r10d,r10d
       xor       r11d,r11d
M00_L03:
       test      r11d,r11d
       jne       short M00_L00
       add       rsp,28
       ret
M00_L04:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 100
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumArray()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+8]
       mov       rcx,2BBC39775C8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2BBC39775C0
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       [rdi+18],rdx
       mov       rcx,2BBC39775C8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 127
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       eax,[rdx+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rdi,rdi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rsi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FF8ACB57BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
M02_L02:
       mov       r11,7FF8AC7403C0
       call      qword ptr [7FF8ACAA03C0]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF8ACB57CC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       add       r14d,eax
       jo        short M02_L05
       mov       rcx,[rbp+0FFC8]
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7403C8
       call      qword ptr [7FF8ACAA03C8]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7403C8
       call      qword ptr [7FF8ACAA03C8]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 317
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumList()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+10]
       mov       rcx,27EC22E75D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,27EC22E75C0
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       [rdi+18],rdx
       mov       rcx,27EC22E75D0
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 127
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       eax,[rdx+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rdi,rdi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rsi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FF8ACB48038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
M02_L02:
       mov       r11,7FF8AC7303C0
       call      qword ptr [7FF8ACA903C0]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF8ACB48110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       add       r14d,eax
       jo        short M02_L05
       mov       rcx,[rbp+0FFC8]
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7303C8
       call      qword ptr [7FF8ACA903C8]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7303C8
       call      qword ptr [7FF8ACA903C8]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 317
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForArray()
       sub       rsp,28
       xor       eax,eax
       xor       edx,edx
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],0
       jle       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       mov       r8,rcx
       cmp       edx,[r8+8]
       jae       short M00_L02
       movsxd    r9,edx
       mov       r8,[r8+r9*8+10]
       add       eax,[r8+8]
       inc       edx
       cmp       [rcx+8],edx
       jg        short M00_L00
M00_L01:
       add       rsp,28
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 71
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForList()
       sub       rsp,28
       xor       eax,eax
       xor       edx,edx
       mov       rcx,[rcx+10]
       mov       r8,rcx
       mov       r8d,[r8+10]
       test      r8d,r8d
       jle       short M00_L01
M00_L00:
       mov       r9,rcx
       cmp       edx,r8d
       jae       short M00_L02
       mov       r9,[r9+8]
       cmp       edx,[r9+8]
       jae       short M00_L03
       movsxd    r10,edx
       mov       r9,[r9+r10*8+10]
       add       eax,[r9+8]
       inc       edx
       cmp       edx,r8d
       jl        short M00_L00
M00_L01:
       add       rsp,28
       ret
M00_L02:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 78
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachArray()
       xor       eax,eax
       mov       rdx,[rcx+8]
       xor       ecx,ecx
       mov       r8d,[rdx+8]
       test      r8d,r8d
       jle       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    r9,ecx
       mov       r9,[rdx+r9*8+10]
       add       eax,[r9+8]
       inc       ecx
       cmp       r8d,ecx
       jg        short M00_L00
M00_L01:
       ret
; Total bytes of code 52
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachList()
       sub       rsp,28
       xor       eax,eax
       mov       rdx,[rcx+10]
       mov       ecx,[rdx+14]
       mov       r8d,ecx
       xor       r9d,r9d
       jmp       short M00_L01
M00_L00:
       add       eax,[r10+8]
M00_L01:
       cmp       r8d,ecx
       jne       short M00_L04
       cmp       r9d,[rdx+10]
       jae       short M00_L02
       mov       r10,[rdx+8]
       cmp       r9d,[r10+8]
       jae       short M00_L05
       movsxd    r11,r9d
       mov       r10,[r10+r11*8+10]
       inc       r9d
       mov       r11d,1
       jmp       short M00_L03
M00_L02:
       mov       r9d,[rdx+10]
       inc       r9d
       xor       r10d,r10d
       xor       r11d,r11d
M00_L03:
       test      r11d,r11d
       jne       short M00_L00
       add       rsp,28
       ret
M00_L04:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 100
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumArray()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+8]
       mov       rcx,20FC1EB75C8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20FC1EB75C0
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       [rdi+18],rdx
       mov       rcx,20FC1EB75C8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 127
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       eax,[rdx+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rdi,rdi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rsi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FF8ACB67BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
M02_L02:
       mov       r11,7FF8AC7503C0
       call      qword ptr [7FF8ACAB03C0]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF8ACB67CC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       add       r14d,eax
       jo        short M02_L05
       mov       rcx,[rbp+0FFC8]
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7503C8
       call      qword ptr [7FF8ACAB03C8]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7503C8
       call      qword ptr [7FF8ACAB03C8]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 317
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumList()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+10]
       mov       rcx,26B64A475D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,26B64A475C0
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       [rdi+18],rdx
       mov       rcx,26B64A475D0
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 127
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       eax,[rdx+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD0],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M02_L07
       test      rdi,rdi
       je        near ptr M02_L08
       xor       r14d,r14d
       mov       r15,[rsi+10]
       mov       r11,[r15+20]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FF8ACB48038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
M02_L02:
       mov       r11,7FF8AC7303C0
       call      qword ptr [7FF8ACA903C0]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r15+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF8ACB48110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rax,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       add       r14d,eax
       jo        short M02_L05
       mov       rcx,[rbp+0FFC8]
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7303C8
       call      qword ptr [7FF8ACA903C8]
       mov       eax,r14d
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       ecx,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M02_L09
       mov       rcx,[rbp+0FFC8]
       mov       r11,7FF8AC7303C8
       call      qword ptr [7FF8ACA903C8]
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 317
```

