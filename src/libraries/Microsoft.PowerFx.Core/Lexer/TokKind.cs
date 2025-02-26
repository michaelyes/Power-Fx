﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.PowerFx.Core.Lexer
{
    internal enum TokKind
    {
        None,

        // Miscellaneous
        Eof,
        Error,

        // Identifiers and literals
        Ident,
        NumLit,
        StrLit,
        Comment,
        Whitespace,
        ReplaceableLit,

        // Punctuators
        Add,
        Sub,
        Mul,
        Div,
        Caret,
        ParenOpen,
        ParenClose,
        CurlyOpen,
        CurlyClose,
        BracketOpen,
        BracketClose,
        Equ,
        Lss,
        LssEqu,
        Grt,
        GrtEqu,
        LssGrt,
        Comma,
        Dot,
        Colon,
        Ampersand,
        PercentSign,
        Semicolon,
        At,

        // Keywords
        Or,
        And,
        Bang,
        True,
        False,
        In,
        Exactin,
        Self,
        Parent,
        KeyOr,
        KeyAnd,
        KeyNot,
        As,

        Lim
    }
}