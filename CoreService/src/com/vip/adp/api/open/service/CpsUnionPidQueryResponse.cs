using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class CpsUnionPidQueryResponse {
		
		///<summary>
		/// 推广位Pid信息列表
		///</summary>
		
		private List<com.vip.adp.api.open.service.PidInfo> pidInfoList_;
		
		///<summary>
		/// 总条数
		///</summary>
		
		private int? total_;
		
		public List<com.vip.adp.api.open.service.PidInfo> GetPidInfoList(){
			return this.pidInfoList_;
		}
		
		public void SetPidInfoList(List<com.vip.adp.api.open.service.PidInfo> value){
			this.pidInfoList_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}