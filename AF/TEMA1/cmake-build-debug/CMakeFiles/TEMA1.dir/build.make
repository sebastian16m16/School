# CMAKE generated file: DO NOT EDIT!
# Generated by "MinGW Makefiles" Generator, CMake Version 3.15

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

SHELL = cmd.exe

# The CMake executable.
CMAKE_COMMAND = "C:\Program Files\JetBrains\CLion 2019.2.1\bin\cmake\win\bin\cmake.exe"

# The command to remove a file.
RM = "C:\Program Files\JetBrains\CLion 2019.2.1\bin\cmake\win\bin\cmake.exe" -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1\cmake-build-debug

# Include any dependencies generated for this target.
include CMakeFiles/TEMA1.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/TEMA1.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/TEMA1.dir/flags.make

CMakeFiles/TEMA1.dir/main.cpp.obj: CMakeFiles/TEMA1.dir/flags.make
CMakeFiles/TEMA1.dir/main.cpp.obj: ../main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/TEMA1.dir/main.cpp.obj"
	C:\TDM-GCC-64\bin\g++.exe  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles\TEMA1.dir\main.cpp.obj -c D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1\main.cpp

CMakeFiles/TEMA1.dir/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/TEMA1.dir/main.cpp.i"
	C:\TDM-GCC-64\bin\g++.exe $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1\main.cpp > CMakeFiles\TEMA1.dir\main.cpp.i

CMakeFiles/TEMA1.dir/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/TEMA1.dir/main.cpp.s"
	C:\TDM-GCC-64\bin\g++.exe $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1\main.cpp -o CMakeFiles\TEMA1.dir\main.cpp.s

# Object files for target TEMA1
TEMA1_OBJECTS = \
"CMakeFiles/TEMA1.dir/main.cpp.obj"

# External object files for target TEMA1
TEMA1_EXTERNAL_OBJECTS =

TEMA1.exe: CMakeFiles/TEMA1.dir/main.cpp.obj
TEMA1.exe: CMakeFiles/TEMA1.dir/build.make
TEMA1.exe: CMakeFiles/TEMA1.dir/linklibs.rsp
TEMA1.exe: CMakeFiles/TEMA1.dir/objects1.rsp
TEMA1.exe: CMakeFiles/TEMA1.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1\cmake-build-debug\CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable TEMA1.exe"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\TEMA1.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/TEMA1.dir/build: TEMA1.exe

.PHONY : CMakeFiles/TEMA1.dir/build

CMakeFiles/TEMA1.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles\TEMA1.dir\cmake_clean.cmake
.PHONY : CMakeFiles/TEMA1.dir/clean

CMakeFiles/TEMA1.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1 D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1 D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1\cmake-build-debug D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1\cmake-build-debug D:\users\f93424c\Documents\Learning\SCHOOL\AF\TEMA1\cmake-build-debug\CMakeFiles\TEMA1.dir\DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/TEMA1.dir/depend
