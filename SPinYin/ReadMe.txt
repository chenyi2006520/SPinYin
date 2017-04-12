1、需要借助json.net进行序列化
2、所有词典采用json格式保存，同时改为json文件

读取方式：
1、直接文件读取  IO
2、通过文件读取储存在缓存 Cache 


输出方式:
1、PINYIN_NONE	不带音调输出: mei hao
2、PINYIN_ASCII	带数字式音调： mei3 hao3
3、PINYIN_UNICODE	  UNICODE 式音调：měi hǎo