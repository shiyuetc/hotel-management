rem ------------------------------------------------------------------
rem cd XXX�̕����ɂ�Seasar.NET��www�t�H���_������p�X���w�肵�ĉ������B
rem ------------------------------------------------------------------
set path=%~dp0.

rem ------------------------------------------------------------------------------
rem ReleaceDocUpdater.exe Seasar�̃z�[���y�[�W��̃����[�X����
rem �@�@�@�@�@�@�@�@�@�@�@�o�[�W�����ԍ����X�V
rem USAGE:
rem    1:���݂̃o�[�W�����ԍ�
rem    2:�V�����o�[�W�����ԍ�
rem    3�`:�X�V�ΏۂƂȂ�t�@�C���p�X�i�����w�肷��ꍇ�͋󔒋�؂�Ńp�X���L�q�j
rem -----------------------------------------------------------------------------

rem s2conariner.net ja
cd C:\source\seasar\www_net\ja
ReleaceDocUpdater.exe 1.3.17 1.3.18 index.html seasarnet.html download.html

rem s2conariner.net en
cd C:\source\seasar\www_net\en
ReleaceDocUpdater.exe 1.3.17 1.3.18 index.html releases.html

rem s2dao.net
cd C:\source\seasar\www_daonet
ReleaceDocUpdater.exe 1.3.17 1.3.18 ja\index.html en\index.html