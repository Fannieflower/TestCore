using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractDetailPageModelHelper : TBeanSerializer<ProtContractDetailPageModel>
	{
		
		public static ProtContractDetailPageModelHelper OBJ = new ProtContractDetailPageModelHelper();
		
		public static ProtContractDetailPageModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractDetailPageModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("size".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSize(value);
					}
					
					
					
					
					
					if ("dataList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel elem1;
								
								elem1 = new com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel();
								com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
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
		
		
		public void Write(ProtContractDetailPageModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotalCount() != null) {
				
				oprot.WriteFieldBegin("totalCount");
				oprot.WriteI32((int)structs.GetTotalCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSize() != null) {
				
				oprot.WriteFieldBegin("size");
				oprot.WriteI32((int)structs.GetSize()); 
				
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
		
		
		public void Validate(ProtContractDetailPageModel bean){
			
			
		}
		
	}
	
}