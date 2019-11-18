using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.lbs.lpc.service.entity{
	
	
	
	public class GetExplainedBarcodesResponseHelper : TBeanSerializer<GetExplainedBarcodesResponse>
	{
		
		public static GetExplainedBarcodesResponseHelper OBJ = new GetExplainedBarcodesResponseHelper();
		
		public static GetExplainedBarcodesResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetExplainedBarcodesResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("header".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.lbs.lpc.service.common.LbsResponseHeader value;
						
						value = new com.vip.lbs.lpc.service.common.LbsResponseHeader();
						com.vip.lbs.lpc.service.common.LbsResponseHeaderHelper.getInstance().Read(value, iprot);
						
						structs.SetHeader(value);
					}
					
					
					
					
					
					if ("explainedResultMap".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, com.vip.lbs.lpc.service.entity.ExplainedResultDetail> value;
						
						value = new Dictionary<string, com.vip.lbs.lpc.service.entity.ExplainedResultDetail>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key2;
								com.vip.lbs.lpc.service.entity.ExplainedResultDetail _val2;
								_key2 = iprot.ReadString();
								
								
								_val2 = new com.vip.lbs.lpc.service.entity.ExplainedResultDetail();
								com.vip.lbs.lpc.service.entity.ExplainedResultDetailHelper.getInstance().Read(_val2, iprot);
								
								value.Add(_key2, _val2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetExplainedResultMap(value);
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
		
		
		public void Write(GetExplainedBarcodesResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHeader() != null) {
				
				oprot.WriteFieldBegin("header");
				
				com.vip.lbs.lpc.service.common.LbsResponseHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("header can not be null!");
			}
			
			
			if(structs.GetExplainedResultMap() != null) {
				
				oprot.WriteFieldBegin("explainedResultMap");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, com.vip.lbs.lpc.service.entity.ExplainedResultDetail > _ir0 in structs.GetExplainedResultMap()){
					
					string _key0 = _ir0.Key;
					com.vip.lbs.lpc.service.entity.ExplainedResultDetail _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					
					com.vip.lbs.lpc.service.entity.ExplainedResultDetailHelper.getInstance().Write(_value0, oprot);
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetExplainedBarcodesResponse bean){
			
			
		}
		
	}
	
}