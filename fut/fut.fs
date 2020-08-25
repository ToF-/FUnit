\ usage : cp -r fut /usr/local/lib/gforth/siteforth/.

require ffl/tst.fs

: .fut-tests-result ( -- )
    tst-get-result
    rot drop 
    esc[ dup if 31 else 32 then 0 .r 109 emit  
    2dup - -rot swap ." tests: " . swap ." passed:" . ." failed:" . 
    esc[ 0 109 emit ;

