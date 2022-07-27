## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForArray()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       xor       esi,esi
       mov       rdi,[rdi+8]
       cmp       dword ptr [rdi+8],0
       jle       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       mov       rdx,rdi
       cmp       esi,[rdx+8]
       jae       short M00_L02
       movsxd    rcx,esi
       mov       rdx,[rdx+rcx*8+10]
       add       eax,[rdx+8]
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L00
M00_L01:
       pop       rbp
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 66
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForList()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       xor       esi,esi
       mov       rdi,[rdi+10]
       mov       rdx,rdi
       mov       edx,[rdx+10]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       mov       rcx,rdi
       cmp       esi,edx
       jae       short M00_L02
       mov       rcx,[rcx+8]
       cmp       esi,[rcx+8]
       jae       short M00_L03
       movsxd    r8,esi
       mov       rcx,[rcx+r8*8+10]
       add       eax,[rcx+8]
       inc       esi
       cmp       esi,edx
       jl        short M00_L00
M00_L01:
       pop       rbp
       ret
M00_L02:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 69
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachArray()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       mov       rdi,[rdi+8]
       xor       esi,esi
       mov       edx,[rdi+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rcx,esi
       mov       rcx,[rdi+rcx*8+10]
       add       eax,[rcx+8]
       inc       esi
       cmp       edx,esi
       jg        short M00_L00
M00_L01:
       pop       rbp
       ret
; Total bytes of code 51
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachList()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       mov       rdi,[rdi+10]
       mov       esi,[rdi+14]
       mov       edx,esi
       xor       ecx,ecx
       jmp       short M00_L01
M00_L00:
       add       eax,[r8+8]
M00_L01:
       cmp       edx,esi
       jne       short M00_L04
       cmp       ecx,[rdi+10]
       jae       short M00_L02
       mov       r8,[rdi+8]
       cmp       ecx,[r8+8]
       jae       short M00_L05
       movsxd    r9,ecx
       mov       r8,[r8+r9*8+10]
       inc       ecx
       mov       r9d,1
       jmp       short M00_L03
M00_L02:
       mov       ecx,[rdi+10]
       inc       ecx
       xor       r8d,r8d
       xor       r9d,r9d
M00_L03:
       test      r9d,r9d
       jne       short M00_L00
       pop       rbp
       ret
M00_L04:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 90
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumArray()
       push      rbp
       push      r14
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,[rdi+8]
       mov       rdi,7FA138005648
       mov       rdx,[rdi]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdi,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7FA138005640
       mov       rsi,[rdi]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       [r14+18],rdi
       mov       rdi,7FA138005648
       mov       rsi,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,r14
M00_L00:
       mov       rsi,rbx
       mov       rdi,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       pop       rbx
       pop       r14
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 128
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       eax,[rsi+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       [rbp-40],rsp
       mov       [rbp-30],rdi
       mov       r14,rdi
       mov       r15,rsi
       mov       rbx,rdx
       test      r15,r15
       je        near ptr M02_L07
       test      rbx,rbx
       je        near ptr M02_L08
       xor       r12d,r12d
       mov       r13,[r14+10]
       cmp       qword ptr [r13+20],0
       je        short M02_L00
       mov       r11,[r13+20]
       jmp       short M02_L01
M02_L00:
       mov       rdi,r14
       mov       rsi,7FA1509D75A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       r15,rax
       mov       [rbp-38],r15
M02_L02:
       mov       rdi,r15
       mov       r11,7FA14F5803C8
       mov       rax,7FA14F5803C8
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r13+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdi,r14
       mov       rsi,7FA1509D7660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,rbx
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       add       r12d,eax
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rdi,r15
       mov       r11,7FA14F5803D0
       mov       rax,7FA14F5803D0
       call      qword ptr [rax]
       mov       eax,r12d
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       edi,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       edi,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       mov       rbp,[rdi]
       mov       [rsp],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp-38],0
       je        short M02_L09
       mov       rdi,[rbp-38]
       mov       r11,7FA14F5803D0
       mov       rax,7FA14F5803D0
       call      qword ptr [rax]
M02_L09:
       nop
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 337
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumList()
       push      rbp
       push      r14
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,[rdi+10]
       mov       rdi,7FB300005650
       mov       rdx,[rdi]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdi,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7FB300005640
       mov       rsi,[rdi]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       [r14+18],rdi
       mov       rdi,7FB300005650
       mov       rsi,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,r14
M00_L00:
       mov       rsi,rbx
       mov       rdi,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       pop       rbx
       pop       r14
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 128
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       eax,[rsi+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       [rbp-40],rsp
       mov       [rbp-30],rdi
       mov       r14,rdi
       mov       r15,rsi
       mov       rbx,rdx
       test      r15,r15
       je        near ptr M02_L07
       test      rbx,rbx
       je        near ptr M02_L08
       xor       r12d,r12d
       mov       r13,[r14+10]
       cmp       qword ptr [r13+20],0
       je        short M02_L00
       mov       r11,[r13+20]
       jmp       short M02_L01
M02_L00:
       mov       rdi,r14
       mov       rsi,7FB316F47900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       r15,rax
       mov       [rbp-38],r15
M02_L02:
       mov       rdi,r15
       mov       r11,7FB315AF03C8
       mov       rax,7FB315AF03C8
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r13+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdi,r14
       mov       rsi,7FB316F479C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,rbx
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       add       r12d,eax
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rdi,r15
       mov       r11,7FB315AF03D0
       mov       rax,7FB315AF03D0
       call      qword ptr [rax]
       mov       eax,r12d
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       edi,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       edi,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       mov       rbp,[rdi]
       mov       [rsp],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp-38],0
       je        short M02_L09
       mov       rdi,[rbp-38]
       mov       r11,7FB315AF03D0
       mov       rax,7FB315AF03D0
       call      qword ptr [rax]
M02_L09:
       nop
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 337
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForArray()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       xor       esi,esi
       mov       rdi,[rdi+8]
       cmp       dword ptr [rdi+8],0
       jle       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       mov       rdx,rdi
       cmp       esi,[rdx+8]
       jae       short M00_L02
       movsxd    rcx,esi
       mov       rdx,[rdx+rcx*8+10]
       add       eax,[rdx+8]
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L00
M00_L01:
       pop       rbp
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 66
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForList()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       xor       esi,esi
       mov       rdi,[rdi+10]
       mov       rdx,rdi
       mov       edx,[rdx+10]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       mov       rcx,rdi
       cmp       esi,edx
       jae       short M00_L02
       mov       rcx,[rcx+8]
       cmp       esi,[rcx+8]
       jae       short M00_L03
       movsxd    r8,esi
       mov       rcx,[rcx+r8*8+10]
       add       eax,[rcx+8]
       inc       esi
       cmp       esi,edx
       jl        short M00_L00
M00_L01:
       pop       rbp
       ret
M00_L02:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 69
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachArray()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       mov       rdi,[rdi+8]
       xor       esi,esi
       mov       edx,[rdi+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rcx,esi
       mov       rcx,[rdi+rcx*8+10]
       add       eax,[rcx+8]
       inc       esi
       cmp       edx,esi
       jg        short M00_L00
M00_L01:
       pop       rbp
       ret
; Total bytes of code 51
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachList()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       mov       rdi,[rdi+10]
       mov       esi,[rdi+14]
       mov       edx,esi
       xor       ecx,ecx
       jmp       short M00_L01
M00_L00:
       add       eax,[r8+8]
M00_L01:
       cmp       edx,esi
       jne       short M00_L04
       cmp       ecx,[rdi+10]
       jae       short M00_L02
       mov       r8,[rdi+8]
       cmp       ecx,[r8+8]
       jae       short M00_L05
       movsxd    r9,ecx
       mov       r8,[r8+r9*8+10]
       inc       ecx
       mov       r9d,1
       jmp       short M00_L03
M00_L02:
       mov       ecx,[rdi+10]
       inc       ecx
       xor       r8d,r8d
       xor       r9d,r9d
M00_L03:
       test      r9d,r9d
       jne       short M00_L00
       pop       rbp
       ret
M00_L04:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 90
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumArray()
       push      rbp
       push      r14
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,[rdi+8]
       mov       rdi,7F29A0005648
       mov       rdx,[rdi]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdi,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7F29A0005640
       mov       rsi,[rdi]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       [r14+18],rdi
       mov       rdi,7F29A0005648
       mov       rsi,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,r14
M00_L00:
       mov       rsi,rbx
       mov       rdi,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       pop       rbx
       pop       r14
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 128
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       eax,[rsi+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       [rbp-40],rsp
       mov       [rbp-30],rdi
       mov       r14,rdi
       mov       r15,rsi
       mov       rbx,rdx
       test      r15,r15
       je        near ptr M02_L07
       test      rbx,rbx
       je        near ptr M02_L08
       xor       r12d,r12d
       mov       r13,[r14+10]
       cmp       qword ptr [r13+20],0
       je        short M02_L00
       mov       r11,[r13+20]
       jmp       short M02_L01
M02_L00:
       mov       rdi,r14
       mov       rsi,7F29B6F775A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       r15,rax
       mov       [rbp-38],r15
M02_L02:
       mov       rdi,r15
       mov       r11,7F29B5B203C8
       mov       rax,7F29B5B203C8
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r13+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdi,r14
       mov       rsi,7F29B6F77660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,rbx
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       add       r12d,eax
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rdi,r15
       mov       r11,7F29B5B203D0
       mov       rax,7F29B5B203D0
       call      qword ptr [rax]
       mov       eax,r12d
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       edi,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       edi,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       mov       rbp,[rdi]
       mov       [rsp],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp-38],0
       je        short M02_L09
       mov       rdi,[rbp-38]
       mov       r11,7F29B5B203D0
       mov       rax,7F29B5B203D0
       call      qword ptr [rax]
M02_L09:
       nop
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 337
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumList()
       push      rbp
       push      r14
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,[rdi+10]
       mov       rdi,7FD568005650
       mov       rdx,[rdi]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdi,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7FD568005640
       mov       rsi,[rdi]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       [r14+18],rdi
       mov       rdi,7FD568005650
       mov       rsi,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,r14
M00_L00:
       mov       rsi,rbx
       mov       rdi,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       pop       rbx
       pop       r14
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 128
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       eax,[rsi+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       [rbp-40],rsp
       mov       [rbp-30],rdi
       mov       r14,rdi
       mov       r15,rsi
       mov       rbx,rdx
       test      r15,r15
       je        near ptr M02_L07
       test      rbx,rbx
       je        near ptr M02_L08
       xor       r12d,r12d
       mov       r13,[r14+10]
       cmp       qword ptr [r13+20],0
       je        short M02_L00
       mov       r11,[r13+20]
       jmp       short M02_L01
M02_L00:
       mov       rdi,r14
       mov       rsi,7FD57D897900
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       r15,rax
       mov       [rbp-38],r15
M02_L02:
       mov       rdi,r15
       mov       r11,7FD57C4403C8
       mov       rax,7FD57C4403C8
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r13+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdi,r14
       mov       rsi,7FD57D8979C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,rbx
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       add       r12d,eax
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rdi,r15
       mov       r11,7FD57C4403D0
       mov       rax,7FD57C4403D0
       call      qword ptr [rax]
       mov       eax,r12d
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       edi,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       edi,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       mov       rbp,[rdi]
       mov       [rsp],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp-38],0
       je        short M02_L09
       mov       rdi,[rbp-38]
       mov       r11,7FD57C4403D0
       mov       rax,7FD57C4403D0
       call      qword ptr [rax]
M02_L09:
       nop
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 337
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForArray()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       xor       esi,esi
       mov       rdi,[rdi+8]
       cmp       dword ptr [rdi+8],0
       jle       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L00:
       mov       rdx,rdi
       cmp       esi,[rdx+8]
       jae       short M00_L02
       movsxd    rcx,esi
       mov       rdx,[rdx+rcx*8+10]
       add       eax,[rdx+8]
       inc       esi
       cmp       [rdi+8],esi
       jg        short M00_L00
M00_L01:
       pop       rbp
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 66
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForList()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       xor       esi,esi
       mov       rdi,[rdi+10]
       mov       rdx,rdi
       mov       edx,[rdx+10]
       test      edx,edx
       jle       short M00_L01
M00_L00:
       mov       rcx,rdi
       cmp       esi,edx
       jae       short M00_L02
       mov       rcx,[rcx+8]
       cmp       esi,[rcx+8]
       jae       short M00_L03
       movsxd    r8,esi
       mov       rcx,[rcx+r8*8+10]
       add       eax,[rcx+8]
       inc       esi
       cmp       esi,edx
       jl        short M00_L00
M00_L01:
       pop       rbp
       ret
M00_L02:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M00_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 69
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachArray()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       mov       rdi,[rdi+8]
       xor       esi,esi
       mov       edx,[rdi+8]
       test      edx,edx
       jle       short M00_L01
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M00_L00:
       movsxd    rcx,esi
       mov       rcx,[rdi+rcx*8+10]
       add       eax,[rcx+8]
       inc       esi
       cmp       edx,esi
       jg        short M00_L00
M00_L01:
       pop       rbp
       ret
; Total bytes of code 51
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.ForEachList()
       push      rbp
       mov       rbp,rsp
       xor       eax,eax
       mov       rdi,[rdi+10]
       mov       esi,[rdi+14]
       mov       edx,esi
       xor       ecx,ecx
       jmp       short M00_L01
M00_L00:
       add       eax,[r8+8]
M00_L01:
       cmp       edx,esi
       jne       short M00_L04
       cmp       ecx,[rdi+10]
       jae       short M00_L02
       mov       r8,[rdi+8]
       cmp       ecx,[r8+8]
       jae       short M00_L05
       movsxd    r9,ecx
       mov       r8,[r8+r9*8+10]
       inc       ecx
       mov       r9d,1
       jmp       short M00_L03
M00_L02:
       mov       ecx,[rdi+10]
       inc       ecx
       xor       r8d,r8d
       xor       r9d,r9d
M00_L03:
       test      r9d,r9d
       jne       short M00_L00
       pop       rbp
       ret
M00_L04:
       call      System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
       int       3
M00_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 90
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumArray()
       push      rbp
       push      r14
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,[rdi+8]
       mov       rdi,7FD4D0005648
       mov       rdx,[rdi]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdi,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7FD4D0005640
       mov       rsi,[rdi]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       [r14+18],rdi
       mov       rdi,7FD4D0005648
       mov       rsi,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,r14
M00_L00:
       mov       rsi,rbx
       mov       rdi,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       pop       rbx
       pop       r14
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 128
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumArray>b__11_0(System.String)
       mov       eax,[rsi+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       [rbp-40],rsp
       mov       [rbp-30],rdi
       mov       r14,rdi
       mov       r15,rsi
       mov       rbx,rdx
       test      r15,r15
       je        near ptr M02_L07
       test      rbx,rbx
       je        near ptr M02_L08
       xor       r12d,r12d
       mov       r13,[r14+10]
       cmp       qword ptr [r13+20],0
       je        short M02_L00
       mov       r11,[r13+20]
       jmp       short M02_L01
M02_L00:
       mov       rdi,r14
       mov       rsi,7FD4E57074E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       r15,rax
       mov       [rbp-38],r15
M02_L02:
       mov       rdi,r15
       mov       r11,7FD4E42B03C8
       mov       rax,7FD4E42B03C8
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r13+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdi,r14
       mov       rsi,7FD4E57075A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,rbx
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       add       r12d,eax
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rdi,r15
       mov       r11,7FD4E42B03D0
       mov       rax,7FD4E42B03D0
       call      qword ptr [rax]
       mov       eax,r12d
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       edi,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       edi,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       mov       rbp,[rdi]
       mov       [rsp],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp-38],0
       je        short M02_L09
       mov       rdi,[rbp-38]
       mov       r11,7FD4E42B03D0
       mov       rax,7FD4E42B03D0
       call      qword ptr [rax]
M02_L09:
       nop
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 337
```

## .NET 6.0.5 (6.0.522.26101), X64 RyuJIT
```assembly
; BenchmarkTests.Tests.CollectionLoop.LinqSumList()
       push      rbp
       push      r14
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,[rdi+10]
       mov       rdi,7F8E48005650
       mov       rdx,[rdi]
       test      rdx,rdx
       jne       short M00_L00
       mov       rdi,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7F8E48005640
       mov       rsi,[rdi]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       [r14+18],rdi
       mov       rdi,7F8E48005650
       mov       rsi,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,r14
M00_L00:
       mov       rsi,rbx
       mov       rdi,offset MD_System.Linq.Enumerable.Sum(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Int32>)
       pop       rbx
       pop       r14
       pop       rbp
       jmp       near ptr System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
; Total bytes of code 128
```
```assembly
; BenchmarkTests.Tests.CollectionLoop+<>c.<LinqSumList>b__12_0(System.String)
       mov       eax,[rsi+8]
       ret
; Total bytes of code 4
```
```assembly
; System.Linq.Enumerable.Sum[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Int32>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       [rbp-40],rsp
       mov       [rbp-30],rdi
       mov       r14,rdi
       mov       r15,rsi
       mov       rbx,rdx
       test      r15,r15
       je        near ptr M02_L07
       test      rbx,rbx
       je        near ptr M02_L08
       xor       r12d,r12d
       mov       r13,[r14+10]
       cmp       qword ptr [r13+20],0
       je        short M02_L00
       mov       r11,[r13+20]
       jmp       short M02_L01
M02_L00:
       mov       rdi,r14
       mov       rsi,7F8E5D7678A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       r15,rax
       mov       [rbp-38],r15
M02_L02:
       mov       rdi,r15
       mov       r11,7F8E5C3103C8
       mov       rax,7F8E5C3103C8
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L06
       mov       r11,[r13+28]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdi,r14
       mov       rsi,7F8E5D767968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rdi,r15
       call      qword ptr [r11]
       mov       rsi,rax
       mov       rax,rbx
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       add       r12d,eax
       jo        short M02_L05
       jmp       short M02_L02
M02_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L06:
       mov       rdi,r15
       mov       r11,7F8E5C3103D0
       mov       rax,7F8E5C3103D0
       call      qword ptr [rax]
       mov       eax,r12d
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       edi,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L08:
       mov       edi,0F
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       mov       rbp,[rdi]
       mov       [rsp],rbp
       lea       rbp,[rbp+40]
       cmp       qword ptr [rbp-38],0
       je        short M02_L09
       mov       rdi,[rbp-38]
       mov       r11,7F8E5C3103D0
       mov       rax,7F8E5C3103D0
       call      qword ptr [rax]
M02_L09:
       nop
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 337
```

