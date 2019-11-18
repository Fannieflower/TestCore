using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GroupValues {
		
		///<summary>
		/// 项值
		///</summary>
		
		private string val_;
		
		///<summary>
		/// 文本
		///</summary>
		
		private string text_;
		
		///<summary>
		/// 额外配置参数
		///</summary>
		
		private string ext_;
		
		public string GetVal(){
			return this.val_;
		}
		
		public void SetVal(string value){
			this.val_ = value;
		}
		public string GetText(){
			return this.text_;
		}
		
		public void SetText(string value){
			this.text_ = value;
		}
		public string GetExt(){
			return this.ext_;
		}
		
		public void SetExt(string value){
			this.ext_ = value;
		}
		
	}
	
}