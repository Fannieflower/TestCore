using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActNoModel {
		
		///<summary>
		/// 活动平台(单个)--已废弃--请使用 actPlatformList
		///</summary>
		
		private int? actPlatform_;
		
		///<summary>
		/// 活动编号
		///</summary>
		
		private string actnoToApi_;
		
		///<summary>
		/// 活动平台列表 -- 下版本改为必传required -- 灰度发布期优先使用actPlatformList，再使用actPlatform
		///</summary>
		
		private List<int?> actPlatformList_;
		
		///<summary>
		/// 营销对象ID（用于分步提交接口）
		///</summary>
		
		private long? promotionObjectId_;
		
		public int? GetActPlatform(){
			return this.actPlatform_;
		}
		
		public void SetActPlatform(int? value){
			this.actPlatform_ = value;
		}
		public string GetActnoToApi(){
			return this.actnoToApi_;
		}
		
		public void SetActnoToApi(string value){
			this.actnoToApi_ = value;
		}
		public List<int?> GetActPlatformList(){
			return this.actPlatformList_;
		}
		
		public void SetActPlatformList(List<int?> value){
			this.actPlatformList_ = value;
		}
		public long? GetPromotionObjectId(){
			return this.promotionObjectId_;
		}
		
		public void SetPromotionObjectId(long? value){
			this.promotionObjectId_ = value;
		}
		
	}
	
}