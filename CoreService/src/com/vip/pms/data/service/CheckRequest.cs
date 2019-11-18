using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CheckRequest {
		
		///<summary>
		/// 1-获取活动基础信息redis缓存
		///</summary>
		
		private int? opcode_;
		
		///<summary>
		/// 缓存类型：1-活动  2-专享价
		///</summary>
		
		private int? cacheType_;
		
		///<summary>
		/// 比如活动号等
		///</summary>
		
		private List<string> keys_;
		
		public int? GetOpcode(){
			return this.opcode_;
		}
		
		public void SetOpcode(int? value){
			this.opcode_ = value;
		}
		public int? GetCacheType(){
			return this.cacheType_;
		}
		
		public void SetCacheType(int? value){
			this.cacheType_ = value;
		}
		public List<string> GetKeys(){
			return this.keys_;
		}
		
		public void SetKeys(List<string> value){
			this.keys_ = value;
		}
		
	}
	
}