#include "../Header/Parser.h"
#include <fstream>
#include <iostream>

Options Parser::parseArgs(int argc, const char* argv[])
{
	namespace fs = std::filesystem;

	Options options;
	std::error_code ec;

	for (int i = 1; i < argc; ++i)
	{
		fs::path argument = argv[i];

		if (fs::is_directory(argument, ec)) {
			options.dirs.insert(argument);
		}
		else if (fs::is_regular_file(argument, ec)) {
			options.files.insert(argument);
		}
		else if (argv[i][0] == '.') {
			options.extensions.insert(argument);
		}
		else if (strcmp(argv[i], "-a") == 0)
		{
			options.bIsAllFiles = true;
		}
		else if (strcmp(argv[i], "-r") == 0)
		{
			options.bIsRecursive = true;
		}
		else
		{
			options.comments.push_back(argv[i]);
		}

	}

	// if there are no directory in arguments -> add current directory to the directories
	if (options.dirs.empty())
	{
		options.dirs.insert(std::filesystem::path{ "./" });
	}

	return options;
}

void Parser::pasteComments(Options&& options)
{
	namespace fs = std::filesystem;

	// scan recursively (all directories and sub-directories)
	if (options.bIsRecursive)
	{
		for (auto& directory : options.dirs)
		{
			for (auto& file : fs::recursive_directory_iterator(directory))
			{
				if (file.is_regular_file() && options.checkExtension(file.path().extension()) and not options.checkFile(file.path()))
				{
					pasteIntoFile(file.path(), options.comments);
				}
			}
		}
	}
	else
	{
		for (auto& directory : options.dirs)
		{
			for (auto& file : fs::directory_iterator(directory))
			{
				if (file.is_regular_file() && options.checkExtension(file.path().extension()) and not options.checkFile(file.path()))
				{
					pasteIntoFile(file, options.comments);
				}
			}
		}
	}

	// lastly put comments into all exact mention files
	for (auto& file : options.files)
	{
		pasteIntoFile(file, options.comments);
	}
}

void Parser::pasteIntoFile(const std::filesystem::path& path, const std::vector<std::string_view>& comments)
{
	// save old file content
	std::ifstream infile(path);
	std::string fileContent((std::istreambuf_iterator<char>(infile)),
							 std::istreambuf_iterator<char>());
	infile.close();

	// open file for write
	std::ofstream ofile(path, std::ios_base::out);

	// write comments and add new line after each one
	for (auto it = comments.begin(); it != comments.end(); it++)
	{
		ofile << *it << std::endl;
	}
	// append old file content
	ofile << fileContent;
}