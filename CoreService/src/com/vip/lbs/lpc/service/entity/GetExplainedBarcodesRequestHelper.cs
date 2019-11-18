using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.lbs.lpc.service.entity{
	
	
	
	public class GetExplainedBarcodesRequestHelper : TBeanSerializer<GetExplainedBarcodesRequest>
	{
		
		public static GetExplainedBarcodesRequestHelper OBJ = new GetExplainedBarcodesRequestHelper();
		
		public static GetExplainedBarcodesRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetExplainedBarcodesRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("header".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.lbs.lpc.service.common.LbsRequestHeader value;
						
						value = new com.vip.lbs.lpc.service.common.LbsRequestHeader();
						com.vip.lbs.lpc.service.common.LbsRequestHeaderHelper.getInstance().Read(value, iprot);
						
						structs.SetHeader(value);
					}
					
					
					
					
					
					if ("explainedBarcodesModelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.lbs.lpc.service.entity.ExplainedBarcodesModel> value;
						
						value = new List<com.vip.lbs.lpc.service.entity.ExplainedBarcodesModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.lbs.lpc.service.entity.ExplainedBarcodesModel elem1;
								
								elem1 = new com.vip.lbs.lpc.service.entity.ExplainedBarcodesModel();
								com.vip.lbs.lpc.service.entity.ExplainedBarcodesModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetExplainedBarcodesModelList(value);
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
		
		
		public void Write(GetExplainedBarcodesRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHeader() != null) {
				
				oprot.WriteFieldBegin("header");
				
				com.vip.lbs.lpc.service.common.LbsRequestHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("header can not be null!");
			}
			
			
			if(structs.GetExplainedBarcodesModelList() != null) {
				
				oprot.WriteFieldBegin("explainedBarcodesModelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.lbs.lpc.service.entity.ExplainedBarcodesModel _item0 in structs.GetExplainedBarcodesModelList()){
					
					
					com.vip.lbs.lpc.service.entity.ExplainedBarcodesModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("explainedBarcodesModelList can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetExplainedBarcodesRequest bean){
			
			
		}
		
	}
	
}