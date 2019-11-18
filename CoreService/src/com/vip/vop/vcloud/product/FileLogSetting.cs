using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.product{
	
	
	
	
	
	public class FileLogSetting {
		
		///<summary>
		/// 合作伙伴id
		///</summary>
		
		private long? hostId_;
		
		///<summary>
		/// 主机类型
		///</summary>
		
		private byte? logType_;
		
		///<summary>
		/// 主机名
		///</summary>
		
		private string remotePath_;
		
		///<summary>
		/// 端口号
		///</summary>
		
		private string localPath_;
		
		///<summary>
		/// 用户名
		///</summary>
		
		private string pattern_;
		
		///<summary>
		/// 主键id
		///</summary>
		
		private long? id_;
		
		public long? GetHostId(){
			return this.hostId_;
		}
		
		public void SetHostId(long? value){
			this.hostId_ = value;
		}
		public byte? GetLogType(){
			return this.logType_;
		}
		
		public void SetLogType(byte? value){
			this.logType_ = value;
		}
		public string GetRemotePath(){
			return this.remotePath_;
		}
		
		public void SetRemotePath(string value){
			this.remotePath_ = value;
		}
		public string GetLocalPath(){
			return this.localPath_;
		}
		
		public void SetLocalPath(string value){
			this.localPath_ = value;
		}
		public string GetPattern(){
			return this.pattern_;
		}
		
		public void SetPattern(string value){
			this.pattern_ = value;
		}
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		
	}
	
}