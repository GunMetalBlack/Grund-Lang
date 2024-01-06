grammar Grund;

program: line* EOF;

line: ifBlock | whileBlock | assignment | blockScopeAssignment | expression (';')?;  

ifBlock: IFBLOCK ('(')? expression (')')? block | IFBLOCK ('(')? expression (')')? block ('ELSE' elseIfBlock);

elseIfBlock: block | ifBlock;

IFBLOCK: 'IF';
 
whileBlock: WHILE expression block | WHILE expression block ('ELSE' elseIfBlock);

WHILE: 'WHILE' | 'UNLESS';
THIS: 'THIS:';
STATIC: 'STATIC';

blockScopeAssignment: STATIC  ':' assignment* 'END' | STATIC  '{' assignment* '}';

assignment: expression '='  expression (';')? ;
declaration: ('VAR' | 'var') IDENTIFIER (';')?; 

FUNC: 'FUNK' | 'METH';
parameter: IDENTIFIER;
STRUCT:  '>';
strucDefinition: STRUCT block;

expression
    : constant              #constantExpression
    | collections           #collectionsExpression
    | expression '[' expression ']' #listAccessionExpression
    | declaration           #declarationsExpression
    | FUNC IDENTIFIER '(' (parameter (',' parameter)*)? ')' block #functionDefinitionExpression
    | IDENTIFIER '(' (expression (',' expression)*)? ')' #functionCallExpression
    | strucDefinition       #strucDefinitionExpression
    | expression '.' expression #dotExpression
    | '(' expression ')'    #parenthesizedExpression
    | '!' expression        #notExpression
    | expression multOP expression #multiplicativeExpression
    | expression addOP expression  #additiveExpression
    | expression compareOP expression #comparisonExpression
    | expression boolOP expression #booleanExpression
    | expression inlineOP #inlineIncrementExpression
    | THROW #throwExpression
    | IDENTIFIER            #identifierExpression
    ;
multOP: '*'|'/'|'%';
addOP:'+'|'-';
compareOP:'=='|'!='|'>'|'<'|'>='|'<=';
inlineOP: '++'| '--';
boolOP: BOOL_OPERATOR;

BOOL_OPERATOR:'AND'|'OR';

constant: INTEGER | FLOAT | STRING | BOOL | NULL;
collections: list | dictionary;
list:'[' (expression (',' expression)*)? ']';
dictionary: '{' (( STRING ':' expression ',')*( STRING ':' expression))? '}';
INTEGER:'-'?[0-9]+;
FLOAT:'-'?[0-9]+ '.' [0-9]+;
STRING: ('"' ~'"'* '"')|('\'' ~'\''* '\'');
BOOL: 'true' | 'false';
NULL: 'NULL';
THROW: 'THROW';

block: ':' line* 'END' |'{' line* '}';

WS : [ \t\r\n]+ -> skip;
LINE_COMMENT:'//' ~[\r\n]* -> skip;

IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
