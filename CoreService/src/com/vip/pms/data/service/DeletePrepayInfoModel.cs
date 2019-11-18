using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class DeletePrepayInfoModel {
		
		///<summary>
		/// 预付活动号
		///</summary>
		
		private List<string> prepayMainNos_;
		
		///<summary>
		/// 操作类型：1=下线；2=废除
		///</summary>
		
		private int? type_;
		
		public List<string> GetPrepayMainNos(){
			return this.prepayMainNos_;
		}
		
		public void SetPrepayMainNos(List<string> value){
			this.prepayMainNos_ = value;
		}
		public int? GetType(){
			return this.type_;
		}
		
		public void SetType(int? value){
			this.type_ = value;
		}
		
	}
	
}