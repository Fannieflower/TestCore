using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.closePo.service{
	
	
	
	
	
	public class PoCloseForWmsReturn {
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string po_;
		
		///<summary>
		/// 销售区域
		///</summary>
		
		private string saleArea_;
		
		///<summary>
		/// 关闭状态, 0 打开 1 关闭
		///</summary>
		
		private int? closeStatus_;
		
		///<summary>
		/// 操作人工号
		///</summary>
		
		private string operatorJobnumber_;
		
		///<summary>
		/// 操作人姓名
		///</summary>
		
		private string operatorName_;
		
		///<summary>
		/// 操作时间
		///</summary>
		
		private string updateTime_;
		
		///<summary>
		/// 每次拉取的起始值
		///</summary>
		
		private long? maxId_;
		
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		public string GetSaleArea(){
			return this.saleArea_;
		}
		
		public void SetSaleArea(string value){
			this.saleArea_ = value;
		}
		public int? GetCloseStatus(){
			return this.closeStatus_;
		}
		
		public void SetCloseStatus(int? value){
			this.closeStatus_ = value;
		}
		public string GetOperatorJobnumber(){
			return this.operatorJobnumber_;
		}
		
		public void SetOperatorJobnumber(string value){
			this.operatorJobnumber_ = value;
		}
		public string GetOperatorName(){
			return this.operatorName_;
		}
		
		public void SetOperatorName(string value){
			this.operatorName_ = value;
		}
		public string GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(string value){
			this.updateTime_ = value;
		}
		public long? GetMaxId(){
			return this.maxId_;
		}
		
		public void SetMaxId(long? value){
			this.maxId_ = value;
		}
		
	}
	
}