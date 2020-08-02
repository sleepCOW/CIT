#include "../Header/Parser.h"

int main(int argc, const char* argv[])
{
	Parser::pasteComments(Parser::parseArgs(argc, argv));
	return 0;
}