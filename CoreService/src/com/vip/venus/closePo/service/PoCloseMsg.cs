using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.closePo.service{
	
	
	
	
	
	public class PoCloseMsg {
		
		///<summary>
		/// 每次拉取的起始值
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string poNo_;
		
		///<summary>
		/// 关闭状态, 0 打开 1 关闭
		///</summary>
		
		private int? closeStatus_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetPoNo(){
			return this.poNo_;
		}
		
		public void SetPoNo(string value){
			this.poNo_ = value;
		}
		public int? GetCloseStatus(){
			return this.closeStatus_;
		}
		
		public void SetCloseStatus(int? value){
			this.closeStatus_ = value;
		}
		
	}
	
}