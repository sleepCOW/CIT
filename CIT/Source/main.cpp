#include <iostream>
#include "../Header/Parser.h"

// not enum class for easy conversion
enum ERRORS : int
{
	MISSING_TXT = 0b001,
	MISSING_DIR = 0b010,
	MISSING_EXT = 0b100,
	OK			= 0b000
};

const char* ErrorMessage =
"\
List of possible error flags\n\
MISSING_TXT = 0b001\n\
MISSING_DIR = 0b010\n\
MISSING_EXT = 0b100\n\
";

int main(int argc, const char* argv[])
{
	Options Args = Parser::parseArgs(argc, argv);

	// Validate arguments
	int Error = ERRORS::OK;
	if (!Args.bIsAllFiles && Args.extensions.empty())
	{
		Error |= MISSING_EXT;
	}
	if (Args.dirs.empty())
	{
		Error |= MISSING_DIR;
	}
	if (Args.comments.empty())
	{
		Error |= MISSING_TXT;
	}

	// Verify no errors in specified arguments
	if (Error == ERRORS::OK)
	{
		Parser::pasteComments(std::move(Args));
	}
	else
	{
		std::cout << "Error occurred = " << Error << '\n' << ErrorMessage;
	}

	return Error;
}