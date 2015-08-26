import os
from setuptools import setup, find_packages

# Get __version__ which is stored in bluffinmuffin/protocol/version.py
ver_file = os.path.join('bluffinmuffin', 'protocol', 'version.py')
exec(open(ver_file).read())

setup(
    name='bluffinmuffin.protocol',
    version=__version__,
    packages=find_packages(),
    namespace_packages=['bluffinmuffin'],
    url='',
    license='',
    author='ericmas001',
    author_email='',
    description=''
)
