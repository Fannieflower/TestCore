using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.newretail{
	
	
	
	
	
	public class GetAfterSaleApplyIdsResponse {
		
		///<summary>
		/// 售后申请单id列表
		///</summary>
		
		private List<long?> apply_ids_;
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		public List<long?> GetApply_ids(){
			return this.apply_ids_;
		}
		
		public void SetApply_ids(List<long?> value){
			this.apply_ids_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}