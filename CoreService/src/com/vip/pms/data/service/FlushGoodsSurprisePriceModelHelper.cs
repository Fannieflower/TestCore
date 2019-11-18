using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class FlushGoodsSurprisePriceModelHelper : TBeanSerializer<FlushGoodsSurprisePriceModel>
	{
		
		public static FlushGoodsSurprisePriceModelHelper OBJ = new FlushGoodsSurprisePriceModelHelper();
		
		public static FlushGoodsSurprisePriceModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(FlushGoodsSurprisePriceModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMid(value);
					}
					
					
					
					
					
					if ("activityNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActivityNo(value);
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
		
		
		public void Write(FlushGoodsSurprisePriceModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMid() != null) {
				
				oprot.WriteFieldBegin("mid");
				oprot.WriteString(structs.GetMid());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("mid can not be null!");
			}
			
			
			if(structs.GetActivityNo() != null) {
				
				oprot.WriteFieldBegin("activityNo");
				oprot.WriteString(structs.GetActivityNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("activityNo can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(FlushGoodsSurprisePriceModel bean){
			
			
		}
		
	}
	
}