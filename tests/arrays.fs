needs lib/arrays.fs

0x55 constant val1
0xAA constant val2 

0xABCD constant valw1 
0x5678 constant valw2 

: words ( -- addr ) { 1 2 3 valw1 4 15 1000 valw2 } ; inline

: bytes ( -- addr ) c{ 41 val1 42 val2 43 } ; inline

: word-nth ( n -- v ) 2* words + flash@ ;

: byte-nth ( n -- v ) bytes + flashc@ ;

: main ( -- ) 3 word-nth 2 byte-nth 2drop ;
