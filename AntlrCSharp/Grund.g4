grammar Grund;

program: line* EOF;

line: statement | ifBlock | whileBlock | functionDefinition | functionCall | assignment | listAccession | inLineIncrement | strucDefinition | memberAccession ;  

statement: (assignment | functionCall | blockScopeAssignment)(';')?;

ifBlock: IFBLOCK ('(')? expression (')')? block | IFBLOCK ('(')? expression (')')? block ('ELSE' elseIfBlock);

elseIfBlock: block | ifBlock;

IFBLOCK: 'IF';
 
whileBlock: WHILE expression block | WHILE expression block ('ELSE' elseIfBlock);

WHILE: 'WHILE' | 'UNLESS';
THIS: 'THIS:';
STATIC: 'STATIC';
CLASSPOINTER: '=>';

blockScopeAssignment: STATIC  ':' assignment* 'END' | STATIC  '{' assignment* '}';

assignment: IDENTIFIER '='  expression (';')? | listAccession '=' expression (';')? | THIS IDENTIFIER '='  expression (';')? | IDENTIFIER CLASSPOINTER  expression'<>'(';')? | memberAssignment(';')?;

memberAssignment: memberAccession '=' expression;

memberAccession: IDENTIFIER '.' IDENTIFIER (';')? | IDENTIFIER '.' functionCall(';')?;

functionCall: IDENTIFIER '(' (expression (',' expression)*)? ')';

inLineIncrement: IDENTIFIER inLineOP (';')? | IDENTIFIER inLineOP (';')?;

FUNC: 'FUNK' | 'METH';
parameter: IDENTIFIER;
STRUCT:  'STRUK';
strucDefinition: STRUCT IDENTIFIER block;
functionDefinition: FUNC IDENTIFIER '(' (parameter (',' parameter)*)? ')' block;

listAccession: IDENTIFIER '[' expression ']';

expression
    : constant              #constantExpression
    | collections           #collectionsExpression
    | listAccession         #listAccessionExpression
    | IDENTIFIER            #identifierExpression
    | functionDefinition    #functionDefinitionExpression
    | functionCall          #functionCallExpression
    | memberAccession       #memberAccessionExpression
    | '(' expression ')'    #parenthesizedExpression
    | '!' expression        #notExpression
    | expression multOP expression #multiplicativeExpression
    | expression addOP expression  #additiveExpression
    | expression compareOP expression #comparisonExpression
    | expression boolOP expression #booleanExpression
    ;
multOP: '*'|'/'|'%';
addOP:'+'|'-' |'++'|'--';
compareOP:'=='|'!='|'>'|'<'|'>='|'<=';
inLineOP: '++'| '--';
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


block: ':' line* 'END' |'{' line* '}';

WS : [ \t\r\n]+ -> skip;
LINE_COMMENT:'//' ~[\r\n]* -> skip;

IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
