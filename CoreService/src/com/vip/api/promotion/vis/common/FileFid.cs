using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.common{
	
	
	
	
	
	public class FileFid {
		
		///<summary>
		/// 文件全局的唯一标识
		///</summary>
		
		private string fid_;
		
		///<summary>
		/// 是否同步
		///</summary>
		
		private bool? isSync_;
		
		public string GetFid(){
			return this.fid_;
		}
		
		public void SetFid(string value){
			this.fid_ = value;
		}
		public bool? GetIsSync(){
			return this.isSync_;
		}
		
		public void SetIsSync(bool? value){
			this.isSync_ = value;
		}
		
	}
	
}