using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class GetAscsResponse {
		
		///<summary>
		/// 售后申请单列表
		///</summary>
		
		private List<vipapis.marketplace.asc.Asc> ascs_;
		
		///<summary>
		/// 是否有下一页
		///</summary>
		
		private bool? has_next_;
		
		public List<vipapis.marketplace.asc.Asc> GetAscs(){
			return this.ascs_;
		}
		
		public void SetAscs(List<vipapis.marketplace.asc.Asc> value){
			this.ascs_ = value;
		}
		public bool? GetHas_next(){
			return this.has_next_;
		}
		
		public void SetHas_next(bool? value){
			this.has_next_ = value;
		}
		
	}
	
}