using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.lbs.track.waybill.service.entity{
	
	
	
	public class LbsAcceptLogisticsTrackResponseHelper : TBeanSerializer<LbsAcceptLogisticsTrackResponse>
	{
		
		public static LbsAcceptLogisticsTrackResponseHelper OBJ = new LbsAcceptLogisticsTrackResponseHelper();
		
		public static LbsAcceptLogisticsTrackResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(LbsAcceptLogisticsTrackResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("header".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.lbs.track.waybill.service.common.LbsResponseHeader value;
						
						value = new com.vip.lbs.track.waybill.service.common.LbsResponseHeader();
						com.vip.lbs.track.waybill.service.common.LbsResponseHeaderHelper.getInstance().Read(value, iprot);
						
						structs.SetHeader(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(LbsAcceptLogisticsTrackResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHeader() != null) {
				
				oprot.WriteFieldBegin("header");
				
				com.vip.lbs.track.waybill.service.common.LbsResponseHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("header can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(LbsAcceptLogisticsTrackResponse bean){
			
			
		}
		
	}
	
}