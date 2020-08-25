require fut/fut.fs

t{ ." this test will pass " cr
    2 2 +   4 ?s
}t

t{ ." this test will also pass " cr
    2 2 +   4 ?s
}t

t{ ." this test will fail " cr
    2 3 +   4 ?s
}t

tst-get-result .fut-tests-result
bye
