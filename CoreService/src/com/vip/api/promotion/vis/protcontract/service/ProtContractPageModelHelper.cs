using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractPageModelHelper : TBeanSerializer<ProtContractPageModel>
	{
		
		public static ProtContractPageModelHelper OBJ = new ProtContractPageModelHelper();
		
		public static ProtContractPageModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractPageModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("totalCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalCount(value);
					}
					
					
					
					
					
					if ("dataList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel elem0;
								
								elem0 = new com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel();
								com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDataList(value);
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
		
		
		public void Write(ProtContractPageModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotalCount() != null) {
				
				oprot.WriteFieldBegin("totalCount");
				oprot.WriteI32((int)structs.GetTotalCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataList() != null) {
				
				oprot.WriteFieldBegin("dataList");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel _item0 in structs.GetDataList()){
					
					
					com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractPageModel bean){
			
			
		}
		
	}
	
}